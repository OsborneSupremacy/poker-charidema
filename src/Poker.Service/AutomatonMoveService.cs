using Poker.Library.Phases;

namespace Poker.Service;

public class AutomatonMoveService : IAutomatonMoveService
{
    private readonly IUserInterfaceService _userInterfaceService;

    public AutomatonMoveService(IUserInterfaceService userInterfaceService)
    {
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
    }

    public Task<MoveResult> ExecuteAsync(MoveArgs args) =>
        args.RoundArgs.Phase switch
        {
            Ante => AnteAsync(args),
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
                Deck = args.RoundArgs.Game.Deck,
                Pot = potOut
            }
        );
    }

    private Task<MoveResult> AnteAsync(MoveArgs args)
    {
        var playerOut = args.PlayerInTurn.DeepClone();
        var ante = args.RoundArgs.Game.Ante;

        _userInterfaceService
            .WriteLines($"{playerOut.Player.Name} antes.");

        playerOut.Player.Stack -= ante;

        return Task.FromResult(
            new MoveResult
            {
                PlayerInTurn = playerOut,
                Deck = args.RoundArgs.Game.Deck,
                Pot = args.Pot + ante
            }
        );
    }
}
