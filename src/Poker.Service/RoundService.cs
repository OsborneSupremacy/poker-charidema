using Poker.Library.Rounds;

namespace Poker.Service;

public class RoundService : IRoundService
{
    private readonly IUserInterfaceService _userInterfaceService;

    private readonly IMoveService _moveService;

    public RoundService(
        IUserInterfaceService userInterfaceService,
        IMoveService moveService
        )
    {
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
        _moveService = moveService ?? throw new ArgumentNullException(nameof(moveService));
    }

    protected Task WriteStartInfoAsync(RoundArgs args)
    {
        _userInterfaceService.WriteHeading(5,
            $"Round {args.RoundNumber} - {args.Round.Name}"
        );

        return Task.CompletedTask;
    }

    public async Task<RoundResult> ExecuteAsync(RoundArgs args)
    {
        await WriteStartInfoAsync(args);

        var playersOut = new List<IInGamePlayer>();

        var ccOut = args.CommunityCards.DeepClone();
        var deckOut = args.Deck.DeepClone();
        var potOut = args.Pot;

        // TODO: if this is a betting round, start with player showing
        // best hand
        for (var p = 0; p < args.Players.Count; p++)
        {
            var moveResult = await _moveService.ExecuteAsync(
                new MoveArgs {
                    PlayerInTurn = args.Players[p],
                    RoundArgs = args,
                    Pot = potOut
                }
            );

            potOut = moveResult.Pot;

            playersOut.Add(moveResult.PlayerInTurn);
        }

        var result = new RoundResult
        {
            Deck = deckOut,
            CommunityCards = ccOut,
            Players = playersOut,
            GameOver = false,
            Pot = potOut
        };

        return result;
    }
}
