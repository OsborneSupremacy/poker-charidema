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

        var participantsWorking = game.Participants.NotFolded().ToList();

        CoordinatePhaseResponse coordinatePhaseResponse = new()
        {
            CommunityCards = game.CommunityCards,
            Deck = await _dealerService.ShuffleAsync(request.Deck),
            GameOver = false,
            Participants = participantsWorking,
            Winners = [],
            Pot = game.Pot
        };

        var gameOver = false;

        foreach (
            var phaseCoordinatorRequest in request
                .Variant
                .Phases
                .Select
                (
                    phase => new CoordinatePhaseRequest
                    {
                        Deck = coordinatePhaseResponse.Deck,
                        Phase = phase,
                        GameOver = gameOver,
                        GameNumber = game.GameNumber,
                        Participants = coordinatePhaseResponse.Participants,
                        Ante = game.Ante,
                        Variant = request.Variant,
                        Button = request.Button,
                        Pot = coordinatePhaseResponse.Pot
                    }
                )
        )
        {
            coordinatePhaseResponse = await _phaseCoordinator
                .ExecuteAsync(phaseCoordinatorRequest);

            gameOver = coordinatePhaseResponse.GameOver;
        }

        return new GameResponse
        {
            CompletedGame = new CompletedGame
            {
                Id = game.Id,
                GameNumber = game.GameNumber,
                Variant = game.Variant,
                Button = game.Button,
                Participants = coordinatePhaseResponse.Participants,
                Winners = coordinatePhaseResponse.Winners,
                PrizeAmount = coordinatePhaseResponse.Pot,
                PrizePerWinner =  coordinatePhaseResponse.Pot / coordinatePhaseResponse.Winners.Count
            },
            Participants = coordinatePhaseResponse.Participants
        };
    }

    private async Task<Game> CreateGameAsync(GameRequest request)
    {
        var gamePlayers = request.Participants
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
            Id = Guid.NewGuid(),
            GameNumber = request.GameCount + 1,
            Button = gameButton,
            Variant = request.Variant,
            Participants = gamePlayers,
            Deck = request.Deck,
            CommunityCards = [],
            Discards = [],
            Ante = await _anteSetService.GetAsync(request, gameButton),
            Pot = 0
        };

        return game;
    }

}
