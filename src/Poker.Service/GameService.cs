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

    protected Task WriteGameStartInfoAsync(Game game)
    {
        _gamePreferencesService.WriteLines(
            $"The game is {game.Variant.Name}",
            $"{game.Button.Name} has the deal"
        );

        return Task.CompletedTask;
    }

    public async Task<Game> PlayAsync(GameArgs args)
    {
        Game game = new()
        {
            Button = args.Button,
            Variant = args.Variant,
            Players = args.Players,
            Deck = args.Deck,
            CommunityCards = new(),
            Discards = new(),
            Rounds = new()
        };

        await WriteGameStartInfoAsync(game);

        System.Console.ReadKey();

        var deck = await _dealerService.ShuffleAsync(args.Deck);

        foreach (var action in args.Variant.RoundActions)
        {
            var result = await _roundActionService
                .ExecuteAsync(new RoundActionArgs()
                {
                    RoundAction = action,
                    Deck = deck,
                    Players = args.Players
                });
            if (result.GameOver)
                return game;
        }

        return game;
    }
}
