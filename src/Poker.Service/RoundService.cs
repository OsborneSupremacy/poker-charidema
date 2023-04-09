using Poker.Library.Rounds;

namespace Poker.Service;

public class RoundService : IRoundService
{
    private readonly IGamePreferencesService _gamePreferencesService;

    public RoundService(IGamePreferencesService gamePreferencesService)
    {
        _gamePreferencesService = gamePreferencesService ?? throw new ArgumentNullException(nameof(gamePreferencesService));
    }

    protected Task WriteStartInfoAsync(RoundArgs args)
    {
        _gamePreferencesService.WriteLines(
            $"Round {args.RoundNumber} - {args.Round.Name}"
        );

        return Task.CompletedTask;
    }

    public async Task<RoundResult> ExecuteAsync(RoundArgs args)
    {
        await WriteStartInfoAsync(args);

        var playersOut = new List<IInGamePlayer>();

        // might want to clone these.
        // I'd like to use Nondestructive mutation, but can't be used with interfaces

        var ccOut = args.CommunityCards;
        var deckOut = args.Deck;
        var potOut = args.Pot;

        // TODO: if this is a betting round, start with player showing
        // best hand
        for (var p = 0; p < args.Players.Count; p++)
        {
            var playerInTurn = args.Players[p];

            _gamePreferencesService
                .WriteLines($"{playerInTurn.Player.Name}'s turn.");

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
