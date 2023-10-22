namespace Poker.Service;

public class GameCoordinationService : IGameCoordinationService
{
    private readonly IUserInterfaceService _userInterfaceService;
    
    private readonly IDealerService _dealerService;
    
    private readonly IGameService _gameService;
    
    public GameCoordinationService(
        IUserInterfaceService userInterfaceService,
        IDealerService dealerService,
        IGameService gameService
        )
    {
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
        _dealerService = dealerService ?? throw new ArgumentNullException(nameof(dealerService));
        _gameService = gameService ?? throw new ArgumentNullException(nameof(gameService));
    }
    
    public async Task<MatchMessage> ExecuteAsync(GameRequest request)
    {
        var gamesOut = request.Match.Games;

        _userInterfaceService
            .WriteHeading(HeadingLevel.Four, $"Starting game {request.Match.Games.Count + 1}");

        // pass button to next player if it's not the first game
        var button = gamesOut.Any()
            ? request.Match.Players.NextPlayer(request.Button)
            : request.Button;

        var gameResponse = await _gameService.PlayAsync(
            new GameRequest()
            {
                Match = request.Match,
                Players = request.Match.Players,
                Variant = request.Match.FixedVariant,
                Deck = request.Match.FixedDeck,
                Button = button
            }
        );

        gamesOut.Add(gameResponse);

        _userInterfaceService
            .WriteHeading(HeadingLevel.Four, $"Game over! TBD wins.");

        gamesOut.Add(gameResponse);
        
        var deck = await _dealerService.ReshuffleAsync(
            new ReshuffleRequest()
            {
                Deck = gameResponse.Game.Deck,
                Players = gameResponse.Players
            }
        );
        
        var matchOut = request.Match with
        {
            Games = gamesOut,
            Players = gameResponse.Players
        };

        WriteStandings(matchOut);
        
        return new MatchMessage {
            Match = matchOut with { FixedDeck = deck },
            Cancelled = false,
            GameResponse = gameResponse
        };
    }
    
    private void WriteStandings(Match match)
    {
        _userInterfaceService.WriteHeading(HeadingLevel.Five, "Standings");
        foreach (var player in match.Players.OrderByDescending(p => p.Stack))
            _userInterfaceService.WriteLine($"{player.Name} - {player.Stack:C}");
        _userInterfaceService.WriteLine();
    }    
}
