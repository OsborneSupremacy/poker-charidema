using System.Text;

namespace Poker.Service;

/// <inheritdoc />
internal class GameCoordinator : IGameCoordinator
{
    private readonly IUserInterfaceService _userInterfaceService;

    private readonly IDealerService _dealerService;

    private readonly IGameService _gameService;

    public GameCoordinator(
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
            ? request.Participants.NextParticipant(request.Button)
            : request.Button;

        var gameResponse = await _gameService.PlayAsync(
            new GameRequest
            {
                Match = request.Match,
                Participants = request.Match.Players.NotBusted().Select(p => new Participant
                {
                    Id = p.Id,
                    Name = p.Name,
                    BeginningStack = p.BeginningStack,
                    Stack = p.Stack,
                    Automaton = p.Automaton,
                    Busted = p.Busted,
                    Stake = 0,
                    Folded = false,
                    CardsInPlay = []
                }).ToList(),
                Variant = request.Match.FixedVariant,
                Deck = request.Match.FixedDeck,
                Button = button
            }
        );

        gamesOut.Add(gameResponse);

        var deck = await _dealerService.ReshuffleAsync(
            new ReshuffleRequest
            {
                Deck = gameResponse.Game.Deck,
                Participants = gameResponse.Participants
            }
        );

        var matchOut = request.Match with
        {
            Games = gamesOut,
            Players = gameResponse.Participants.Select(p => new Player
            {
                Id = p.Id,
                Name = p.Name,
                BeginningStack = p.BeginningStack,
                Stack = p.Stack,
                Automaton = p.Automaton,
                Busted = p.Busted
            }).ToList(),
        };

        WriteStandings(matchOut);

        return new MatchMessage
        {
            Match = matchOut with { FixedDeck = deck },
            Cancelled = false,
            GameResponse = gameResponse
        };
    }

    private void WriteStandings(Match match)
    {
        var stacks = match.Players
            .OrderByDescending(p => p.Stack)
            .Select(WritePlayerStanding);

        _userInterfaceService.WriteList("Standings", stacks.ToArray());
    }

    private static string WritePlayerStanding(Player player) =>
        player.Busted
            ? $"{player.Name} - Busted"
            : $"{player.Name} - {player.Stack:C0}";
}
