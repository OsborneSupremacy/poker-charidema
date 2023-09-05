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

        // I'd like to use Nondestructive mutation, but can't be used with interfaces
        var ccOut = args.CommunityCards.DeepClone();
        var deckOut = args.Deck.DeepClone();
        var potOut = args.Pot.DeepClone();

        // TODO: if this is a betting round, start with player showing
        // best hand
        for (var p = 0; p < args.Players.Count; p++)
        {
            var playerInTurn = args.Players[p];

            var moveResult = await _moveService.ExecuteAsync(
                new MoveArgs {
                    PlayerInTurn = args.Players[p],
                    RoundArgs = args
                }
            );


            playersOut.Add(playerInTurn);
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
