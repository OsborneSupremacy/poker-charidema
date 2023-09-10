using Poker.Library.Rounds;

namespace Poker.Service;

public class UserMoveService : IUserMoveService
{
    private readonly IUserInterfaceService _userInterfaceService;

    public UserMoveService(IUserInterfaceService userInterfaceService)
    {
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
    }

    public Task<MoveResult> ExecuteAsync(MoveArgs args) =>
        args.RoundArgs.Round switch
        {
            Ante => AntePromptAsync(args),
            _ => DefaultMoveAsync(args)
        };

    private Task<MoveResult> DefaultMoveAsync(MoveArgs args)
    {
        var playerOut = args.PlayerInTurn.DeepClone();
        uint potOut = args.Pot;

        return Task.FromResult(
            new MoveResult
            {
                PlayerInTurn = playerOut,
                Pot = potOut
            }
        );
    }

    private Task<MoveResult> AntePromptAsync(MoveArgs args) =>
        _userInterfaceService.PromptForBool($"Ante {args.RoundArgs.Game.Ante:C}?") switch
        {
            true => AnteAsync(args),
            false => SitOutAsync(args)
        };

    private Task<MoveResult> AnteAsync(MoveArgs args)
    {
        var playerOut = args.PlayerInTurn.DeepClone();
        var ante = args.RoundArgs.Game.Ante;

        _userInterfaceService
            .WriteLines($"{playerOut.Player.Name} antes.");
        playerOut.Player.Stack = args.PlayerInTurn.Player.Stack - ante;

        return Task.FromResult(
            new MoveResult
            {
                PlayerInTurn = playerOut,
                Pot = args.Pot + ante
            }
        );
    }

    private Task<MoveResult> SitOutAsync(MoveArgs args)
    {
        var playerOut = args.PlayerInTurn.DeepClone();

        _userInterfaceService
            .WriteLines($"{playerOut.Player.Name} sits out.");
        playerOut.Folded = true;

        return Task.FromResult(
            new MoveResult
            {
                PlayerInTurn = playerOut,
                Pot = args.Pot
            }
        );
    }
}
