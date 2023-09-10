using Poker.Library.Rounds;

namespace Poker.Service;

public class RoundService : IRoundService
{
    private readonly IUserInterfaceService _userInterfaceService;

    private readonly IMoveServiceFactory _moveServiceFactory;

    public RoundService(
        IUserInterfaceService userInterfaceService,
        IMoveServiceFactory moveServiceFactory
        )
    {
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
        _moveServiceFactory = moveServiceFactory ?? throw new ArgumentNullException(nameof(moveServiceFactory));
    }

    protected Task WriteStartInfoAsync(RoundArgs args)
    {
        _userInterfaceService.WriteHeading(
            HeadingLevel.Five,
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

        // TODO: if this is a betting round and any non-community cards are face-up, start with player showing
        // best hand. Otherwise, start with player to the left of dealer
        for (var p = 0; p < args.Game.Players.Count; p++)
        {
            MoveArgs moveArgs = new()
            {
                PlayerInTurn = args.Game.Players[p],
                RoundArgs = args,
                Pot = potOut
            };

            var moveResult = await _moveServiceFactory.Get(moveArgs)
                .ExecuteAsync(moveArgs);

            potOut = moveResult.Pot;
            playersOut.Add(moveResult.PlayerInTurn);
        }

        return new RoundResult
        {
            Deck = deckOut,
            CommunityCards = ccOut,
            Players = playersOut,
            GameOver = false,
            Pot = potOut
        };
    }
}
