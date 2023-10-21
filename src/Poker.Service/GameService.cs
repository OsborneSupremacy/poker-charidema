namespace Poker.Service;

public class GameService : IGameService
{
    private readonly IDealerService _dealerService;

    private readonly IAnteSetService _anteSetService;

    private readonly IUserInterfaceService _userInterfaceService;
    
    private readonly IPhaseTransitionService _phaseTransitionService;

    public GameService(
        IDealerService dealerService,
        IAnteSetService anteSetService,
        IUserInterfaceService userInterfaceService,
        IPhaseTransitionService phaseTransitionService
        )
    {
        _dealerService = dealerService ?? throw new ArgumentNullException(nameof(dealerService));
        _anteSetService = anteSetService ?? throw new ArgumentNullException(nameof(anteSetService));
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
        _phaseTransitionService = phaseTransitionService ?? throw new ArgumentNullException(nameof(phaseTransitionService));
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
     
        PhaseTransitionResponse phaseTransitionResponse = new()
        {
            PhaseResponse = new()
            {
                CommunityCards = game.CommunityCards,
                Deck = await _dealerService.ShuffleAsync(request.Deck),
                GameOver = false,
                Players = game.Players,
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

        foreach (var phase in request.Variant.Phases)
        {
            PhaseTransitionRequest phaseTransitionRequest = new()
            {
                Game = phaseTransitionResponse.GameResponse.Game,
                Deck = phaseTransitionResponse.PhaseResponse.Deck,
                Phase = phase 
            };
            
            phaseTransitionResponse = await _phaseTransitionService
                .ExecuteAsync(phaseTransitionRequest);

            if (phaseTransitionResponse.PhaseResponse.GameOver)
                return phaseTransitionResponse.GameResponse;
        }

        return phaseTransitionResponse.GameResponse;
    }

    private async Task<Game> CreateGameAsync(GameRequest request)
    {
        var gamePlayers = request.Players
            .Select(p => p with
            {
                Cards = new(),
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
            CommunityCards = new(),
            Discards = new(),
            Ante = await _anteSetService.GetAsync(request, gameButton),
            Pot = 0
        };

        return game;
    }

}
