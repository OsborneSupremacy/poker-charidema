using Poker.Library.Rounds;

namespace Poker.Service;

public class GameService : IGameService
{
    private readonly IDealerService _dealerService;

    private readonly IRoundService _roundService;

    private readonly IAnteSetService _anteSetService;

    private readonly IUserInterfaceService _userInterfaceService;

    public GameService(
        IDealerService dealerService,
        IRoundService roundService,
        IAnteSetService anteSetService,
        IUserInterfaceService userInterfaceService
        )
    {
        _dealerService = dealerService ?? throw new ArgumentNullException(nameof(dealerService));
        _roundService = roundService ?? throw new ArgumentNullException(nameof(roundService));
        _anteSetService = anteSetService ?? throw new ArgumentNullException(nameof(anteSetService));
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
    }

    protected Task WriteStartInfoAsync(Game game)
    {
        _userInterfaceService.WriteLines(
            $"The game is {game.Variant.Name}.",
            $"{game.Button.Player.Name} has the deal.",
            $"Ante is set at {game.Ante:C}"
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
            Discards = new(),
            Ante = await _anteSetService.GetAsync(args, gameButton),
            Pot = 0
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
                    Game = game,
                    Round = action,
                    Deck = deck,
                    CommunityCards = new(),
                    Players = gamePlayers,
                    StartingPlayer = gamePlayers.NextPlayer(gameButton),
                    RoundNumber = ++r,
                    Pot = game.Pot
                });

            game = game with
            {
                Deck = result.Deck,
                CommunityCards = result.CommunityCards,
                Players = result.Players,
                Pot = result.Pot
            };

            _userInterfaceService.WriteLine();
            _userInterfaceService.WriteLine($"Pot: {game.Pot:C}");

            if (result.GameOver)
                return game;
        }

        return game;
    }
}
