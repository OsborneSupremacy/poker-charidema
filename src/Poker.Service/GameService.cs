namespace Poker.Service;

public class GameService : IGameService
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
            $"Ante is set at {game.Ante:C}"
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
                Players = game.Players,
                Winners = [],
                Pot = game.Pot
            },
            GameResponse = new()
            {
                Game = game,
                Players = game.Players,
                Variant = game.Variant,
                Button = game.Button
            }
        };

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
                        Phase = phase
                    }
                )
        )
        {
            phaseCoordinatorResponse = await _phaseCoordinator
                .ExecuteAsync(phaseCoordinatorRequest);

            if (phaseCoordinatorResponse.PhaseResponse.GameOver)
                return phaseCoordinatorResponse.GameResponse;
        }

        return phaseCoordinatorResponse.GameResponse;
    }

    private async Task<Game> CreateGameAsync(GameRequest request)
    {
        var gamePlayers = request.Players
            .Select(p => p with
            {
                Cards = [],
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
