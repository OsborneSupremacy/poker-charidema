using Poker.Library.RoundActions;

namespace Poker.Service;

public class GameService : IGameService
{
    private readonly IDealerService _dealerService;

    private readonly IRoundActionService _roundActionService;

    private readonly IGamePreferencesService _gamePreferencesService;

    public GameService(
        IDealerService dealerService,
        IRoundActionService roundActionService,
        IGamePreferencesService gamePreferencesService
        )
    {
        _dealerService = dealerService ?? throw new ArgumentNullException(nameof(dealerService));
        _roundActionService = roundActionService ?? throw new ArgumentNullException(nameof(roundActionService));
        _gamePreferencesService = gamePreferencesService ?? throw new ArgumentNullException(nameof(gamePreferencesService));
    }

    protected Task WriteStartInfoAsync(Game game)
    {
        _gamePreferencesService.WriteLines(
            $"The game is {game.Variant.Name}",
            $"{game.Button.Player.Name} has the deal"
        );

        return Task.CompletedTask;
    }

    public async Task<Game> PlayAsync(GameArgs args)
    {
        var gamePlayers = args.Players
            .Select(p => new InGamePlayer
            {
                Player = p,
                Stack = p.Stack,
                Folded = false
            })
            .ToList<IInGamePlayer>();

        var gameButton = gamePlayers
            .Single(x => x.Player.Id == args.Button.Id);

        Game game = new()
        {
            Button = gameButton,
            Variant = args.Variant,
            Players = gamePlayers,
            Deck = args.Deck,
            CommunityCards = new(),
            Discards = new()
        };

        await WriteStartInfoAsync(game);

        var deck = await _dealerService.ShuffleAsync(args.Deck);

        uint r = 0;
        foreach (var action in args.Variant.RoundActions)
        {
            var result = await _roundActionService
                .ExecuteAsync(new RoundActionArgs()
                {
                    RoundAction = action,
                    Deck = deck,
                    Players = gamePlayers,
                    StartingPlayer = gamePlayers.NextPlayer(gameButton),
                    RoundNumber = ++r
                });
            if (result.GameOver)
                return game;
        }

        return game;
    }
}
