using Poker.Library.Phases;

namespace Poker.Service;

public class PhaseService : IPhaseService
{
    private readonly IUserInterfaceService _userInterfaceService;

    private readonly IMoveServiceFactory _moveServiceFactory;

    public PhaseService(
        IUserInterfaceService userInterfaceService,
        IMoveServiceFactory moveServiceFactory
        )
    {
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
        _moveServiceFactory = moveServiceFactory ?? throw new ArgumentNullException(nameof(moveServiceFactory));
    }

    protected Task WriteStartInfoAsync(PhaseArgs args)
    {
        _userInterfaceService.WriteHeading(
            HeadingLevel.Five,
            $"{args.Phase.Name}"
        );

        return Task.CompletedTask;
    }

    public async Task<PhaseResult> ExecuteAsync(PhaseArgs args)
    {
        await WriteStartInfoAsync(args);

        // TODO: do not iterate over players when phase is a board action

        var playersOut = new List<IInGamePlayer>();

        var ccOut = args.CommunityCards.DeepClone();
        var deckOut = args.Deck.DeepClone();
        var potOut = args.Pot;

        // TODO: if this is a betting round and any non-community cards are face-up, start with player showing
        // best hand. Otherwise, start with player to the left of dealer
        var playerInTurn = args.StartingPlayer;

        while (playersOut.Count < args.Game.Players.Count)
        {
            MoveArgs moveArgs = new()
            {
                PlayerInTurn = playerInTurn,
                RoundArgs = args,
                Pot = potOut
            };

            var moveResult = await _moveServiceFactory
                .Get(moveArgs)
                .ExecuteAsync(moveArgs);

            potOut = moveResult.Pot;
            playersOut.Add(moveResult.PlayerInTurn);

            playerInTurn = args.Game.Players.NextPlayer(playerInTurn);
        }

        return new PhaseResult
        {
            Deck = deckOut,
            CommunityCards = ccOut,
            Players = playersOut,
            GameOver = false,
            Pot = potOut
        };
    }
}
