
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

    public async Task<CoordinateGameResponse> ExecuteAsync(CoordinateGameRequest request)
    {
        var playersIn = request.Players.ToList();
        var gamesOut = request.GameHistory.ToList();

        _userInterfaceService
            .WriteHeading(HeadingLevel.Four, $"Starting game {gamesOut.Count + 1}");

        var participantsIn = playersIn.NotBusted().Select(p => new Participant
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
        }).ToList();

        var button = DetermineButton(request.InitialButtonId, gamesOut, request.Players, participantsIn);

        var gameResponse = await _gameService.PlayAsync(
            new GameRequest
            {
                GameCount = gamesOut.Count,
                AntePreferences = request.AntePreferences,
                Participants = participantsIn,
                Variant = request.Variant,
                Deck = request.Deck,
                Button = button
            }
        );

        var totalMoneyInPlay = gameResponse.Participants
            .Sum(p => p.Stack);

#if DEBUG
        Console.WriteLine($"Participants have {totalMoneyInPlay:C0} in play.");
        Console.WriteLine(totalMoneyInPlay == request.TotalMoneyInPlay
            ? "Total money in play matches the match total."
            : $"Total money in play does not match the match total: {request.TotalMoneyInPlay:C0}. Difference: {totalMoneyInPlay - request.TotalMoneyInPlay:C0}. Something went wrong.");
#endif

        gamesOut.Add(gameResponse.CompletedGame);

        var deck = await _dealerService.ReshuffleAsync(
            new ReshuffleRequest
            {
                Deck = request.Deck,
                Participants = gameResponse.Participants
            }
        );

        WriteStandings(gameResponse.Participants);

        return new CoordinateGameResponse
        {
            GameResponse = gameResponse
        };
    }


    /// <summary>
    /// Determine the button for the game being coordinated. Can be a little complicated,
    /// since we need to account for players that have busted and are no longer participating.
    /// </summary>
    private static Participant DetermineButton(
        Guid initialButtonId,
        List<CompletedGame> gameHistory,
        IReadOnlyList<Player> players,
        IReadOnlyList<Participant> participants
        )
    {
        if(!gameHistory.Any())
            return participants.Single(p => p.Id == initialButtonId);

        var playersIn = players.ToList();

        var lastButtonId = gameHistory
            .OrderByDescending(g => g.GameNumber)
            .Select(g => g.Id)
            .FirstOrDefault();

        var lastButton = playersIn.Single(p => p.Id == lastButtonId);
        var nextButton = playersIn.ToList().NextPlayer(lastButton);

        while (!participants.Select(p => p.Id).Contains(nextButton.Id))
            nextButton = playersIn.NextPlayer(lastButton);

        return participants.Single(p => p.Id == nextButton.Id);
    }

    private void WriteStandings(IReadOnlyList<Participant> participants)
    {
        var stacks = participants
            .OrderByDescending(p => p.Stack)
            .Select(WritePlayerStanding);

        _userInterfaceService.WriteList("Standings", stacks.ToArray());
    }

    private static string WritePlayerStanding(Participant player) =>
        (player.Busted, player.Stack) switch
        {
            (false, _) => $"{player.Name}: {player.Stack:C0}",
            (true, 0) => $"{player.Name}: Busted",
            (true, _) => $"{player.Name}: Busted, {player.Stack:C0} In the Red (This Shouldn't Happen)"
        };
}
