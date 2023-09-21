namespace Poker.Service;

public class GameService : IGameService
{
    private readonly IDealerService _dealerService;

    private readonly IPhaseService _phaseService;

    private readonly IAnteSetService _anteSetService;

    private readonly IUserInterfaceService _userInterfaceService;

    public GameService(
        IDealerService dealerService,
        IPhaseService phaseService,
        IAnteSetService anteSetService,
        IUserInterfaceService userInterfaceService
        )
    {
        _dealerService = dealerService ?? throw new ArgumentNullException(nameof(dealerService));
        _phaseService = phaseService ?? throw new ArgumentNullException(nameof(phaseService));
        _anteSetService = anteSetService ?? throw new ArgumentNullException(nameof(anteSetService));
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
    }

    protected Task WriteStartInfoAsync(Game game)
    {
        _userInterfaceService.WriteLines(
            $"The game is {game.Variant.Name}.",
            $"{game.Button.Participant.Name} has the deal.",
            $"Ante is set at {game.Ante:C}"
        );

        return Task.CompletedTask;
    }

    public async Task<GameResponse> PlayAsync(GameRequest request)
    {
        var game = await CreateGameAsync(request);
        await WriteStartInfoAsync(game);

        var deck = await _dealerService
            .ShuffleAsync(request.Deck);

        foreach (var action in request.Variant.Phases)
        {
            var result = await _phaseService
                .ExecuteAsync(new PhaseRequest
                {
                    Game = game,
                    Phase = action,
                    Deck = deck,
                    CommunityCards = new(),
                    StartingPlayer = game.Players.NextPlayer(game.Button),
                    Pot = game.Pot
                });

            deck = result.Deck;

            game = game with
            {
                Deck = deck,
                CommunityCards = result.CommunityCards,
                Players = result.Players,
                Pot = result.Pot
            };

            var user = result.Players.Single(x => !x.Participant.Automaton);

            _userInterfaceService
                .WriteLine()
                .WriteLine($"Pot: {game.Pot:C}")
                .WriteLine()
                .WriteLine("Your Cards")
                .RenderCards(user.Cards);

            if (result.GameOver)
                return new GameResponse {
                    Match = request.Match,
                    Players = request.Players,
                    Variant = request.Variant,
                    Button = request.Button
                };
        }

        return new GameResponse
        {
            Match = request.Match,
            Players = request.Players,
            Variant = request.Variant,
            Button = request.Button
        };
    }

    private async Task<Game> CreateGameAsync(GameRequest request)
    {
        var gamePlayers = request.Players
            .Select(p => new Player
            {
                Participant = p,
                Cards = new(),
                Folded = false
            })
            .ToList();

        var gameButton = gamePlayers
            .Single(x => x.Participant.Id == request.Button.Id);

        Game game = new()
        {
            Button = gameButton,
            Variant = request.Variant,
            Players = gamePlayers,
            Deck = request.Deck,
            CommunityCards = new(),
            Discards = new(),
            Ante = await _anteSetService.GetAsync(request, gameButton),
            Pot = 0
        };

        return game;
    }
}
