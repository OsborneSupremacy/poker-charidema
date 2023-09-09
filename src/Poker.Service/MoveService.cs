using Poker.Library.Rounds;

namespace Poker.Service;

public class MoveService : IMoveService
{
    private readonly IUserInterfaceService _userInterfaceService;

    public MoveService(IUserInterfaceService userInterfaceService)
    {
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
    }

    public Task<MoveResult> ExecuteAsync(MoveArgs args)
    {
        var playerOut = args.PlayerInTurn.DeepClone();
        uint potOut = args.Pot;

        if (args.RoundArgs.Round is Ante)
        {
            var ante = args.RoundArgs.Game.Ante;

            _userInterfaceService
                .WriteLines($"{playerOut.Player.Name} antes.");

            playerOut.Stack = args.PlayerInTurn.Stack - ante;
            potOut += ante; 
        }
        else
        {
            _userInterfaceService
                .WriteLines($"{args.PlayerInTurn.Player.Name}'s turn.");
        }

        return Task.FromResult(
            new MoveResult {
                PlayerInTurn = playerOut,
                Pot = potOut
            }
        );
    }
}
