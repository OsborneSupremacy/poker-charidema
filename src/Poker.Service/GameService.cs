using Poker.Library.Rounds;

namespace Poker.Service;

public class GameService : IGameService
{
    private readonly IDealerService _dealerService;

    private readonly IRoundService _roundService;

    private readonly IGamePreferencesService _gamePreferencesService;

    private readonly IUserInterfaceService _userInterfaceService;

    public GameService(
        IDealerService dealerService,
        IRoundService roundService,
        IGamePreferencesService gamePreferencesService,
        IUserInterfaceService userInterfaceService
        )
    {
        _dealerService = dealerService ?? throw new ArgumentNullException(nameof(dealerService));
        _roundService = roundService ?? throw new ArgumentNullException(nameof(roundService));
        _gamePreferencesService = gamePreferencesService ?? throw new ArgumentNullException(nameof(gamePreferencesService));
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
    }

    protected Task WriteStartInfoAsync(Game game)
    {
        _userInterfaceService.WriteLines(
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
                Cards = new(),
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

        var deck = await _dealerService
            .ShuffleAsync(args.Deck);

        uint r = 0;
        foreach (var action in args.Variant.Rounds)
        {
            var result = await _roundService
                .ExecuteAsync(new RoundArgs()
                {
                    Round = action,
                    Deck = deck,
                    CommunityCards = new(),
                    Players = gamePlayers,
                    StartingPlayer = gamePlayers.NextPlayer(gameButton),
                    RoundNumber = ++r,
                    Pot = 0
                });
            if (result.GameOver)
                return game;
        }

        return game;
    }



}
