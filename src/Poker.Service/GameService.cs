namespace Poker.Service;

/// <inheritdoc />
internal class GameService : IGameService
{
    private readonly IDealerService _dealerService;

    private readonly IAnteSetService _anteSetService;

    private readonly IUserInterfaceService _userInterfaceService;

    private readonly IPhaseCoordinator _phaseCoordinator;

    public GameService(
        IDealerService dealerService,
        IAnteSetService anteSetService,
        IUserInterfaceService userInterfaceService,
        IPhaseCoordinator phaseCoordinator
        )
    {
        _dealerService = dealerService ?? throw new ArgumentNullException(nameof(dealerService));
        _anteSetService = anteSetService ?? throw new ArgumentNullException(nameof(anteSetService));
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
        _phaseCoordinator = phaseCoordinator ?? throw new ArgumentNullException(nameof(phaseCoordinator));
    }

    private Task WriteStartInfoAsync(Game game)
    {
        _userInterfaceService.WriteLines(
            $"The game is {game.Variant.Name}.",
            $"{game.Button.Name} has the deal.",
            $"Ante is set at {game.Ante:C0}"
        );

        return Task.CompletedTask;
    }

    public async Task<GameResponse> PlayAsync(GameRequest request)
    {
        var game = await CreateGameAsync(request);
        await WriteStartInfoAsync(game);

        PhaseCoordinatorResponse phaseCoordinatorResponse = new()
        {
            PhaseResponse = new()
            {
                CommunityCards = game.CommunityCards,
                Deck = await _dealerService.ShuffleAsync(request.Deck),
                GameOver = false,
                Players = game.Players.InMatch().ToList(),
                Winners = [],
                Pot = game.Pot
            },
            GameResponse = new()
            {
                Game = game,
                Players = game.Players.InMatch().ToList(),
                Variant = game.Variant,
                Button = game.Button
            }
        };

        var gameOver = false;

        foreach (
            var phaseCoordinatorRequest in request
                .Variant
                .Phases
                .Select
                (
                    phase => new PhaseCoordinatorRequest
                    {
                        Game = phaseCoordinatorResponse.GameResponse.Game,
                        Deck = phaseCoordinatorResponse.PhaseResponse.Deck,
                        Phase = phase,
                        GameOver = gameOver
                    }
                )
        )
        {
            phaseCoordinatorResponse = await _phaseCoordinator
                .ExecuteAsync(phaseCoordinatorRequest);

            gameOver = phaseCoordinatorResponse.PhaseResponse.GameOver;
        }

        return phaseCoordinatorResponse.GameResponse;
    }

    private async Task<Game> CreateGameAsync(GameRequest request)
    {
        var gamePlayers = request.Players.InMatch()
            .Select(p => p with
            {
                CardsInPlay = [],
                Folded = false
            })
            .ToList();

        var gameButton = gamePlayers
            .Single(x => x.Id == request.Button.Id);

        Game game = new()
        {
            Button = gameButton,
            Variant = request.Variant,
            Players = gamePlayers,
            Deck = request.Deck,
            CommunityCards = [],
            Discards = [],
            Ante = await _anteSetService.GetAsync(request, gameButton),
            Pot = 0
        };

        return game;
    }

}
