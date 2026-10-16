namespace Poker.Service;

/// <inheritdoc />
internal class MatchService : IMatchService
{
    private readonly IMatchPreferencesService _matchPreferencesService;

    private readonly IGamePreferencesService _gamePreferencesService;

    private readonly IUserInterfaceService _userInterfaceService;

    private readonly IGameCoordinator _gameCoordinator;

    public MatchService(
        IMatchPreferencesService matchPreferencesService,
        IGamePreferencesService gamePreferencesService,
        IUserInterfaceService userInterfaceService,
        IGameCoordinator gameCoordinator
        )
    {
        _matchPreferencesService = matchPreferencesService ?? throw new ArgumentNullException(nameof(matchPreferencesService));
        _gamePreferencesService = gamePreferencesService ?? throw new ArgumentNullException(nameof(gamePreferencesService));
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
        _gameCoordinator = gameCoordinator ?? throw new ArgumentNullException(nameof(gameCoordinator));
    }

    private async Task<MatchResponse> PlayGames(
        MatchRequest request,
        Func<MatchRequest, bool> playGameDelegate
        )
    {
        var gameHistory = request.Match.GameHistory.ToList();
        var playersWorking = request.Match.Players;
        var matchWorking = request.Match;

        var keepPlaying = true;

        while (keepPlaying)
        {
            matchWorking = matchWorking with
            {
                GameHistory = gameHistory,
                Players = playersWorking
            };

            var coordinatedGameResponse = await _gameCoordinator.ExecuteAsync(
                new CoordinateGameRequest
                {
                    AntePreferences = request.Match.AntePreferences,
                    TotalMoneyInPlay = matchWorking.TotalMoneyInPlay,
                    Players = playersWorking,
                    Variant = request.Match.FixedVariant,
                    Deck = request.Match.FixedDeck,
                    InitialButtonId = request.InitialButton.Id,
                    GameHistory = gameHistory
                }
            );

            gameHistory.Add(coordinatedGameResponse.GameResponse.CompletedGame);
            playersWorking = UpdatePlayers(coordinatedGameResponse.GameResponse.Participants, playersWorking);

            matchWorking = matchWorking with
            {
                GameHistory = gameHistory,
                Players = playersWorking
            };

            keepPlaying = playGameDelegate(request with
            {
                Match = matchWorking
            });
        }

        return new MatchResponse
        {
            Cancelled = false,
            Match = matchWorking,
            Winners = playersWorking.Richest(),
            PlayAgain = false // need to create match preferences service to handle this
        };
    }

    private Task<MatchResponse> PlayFixedNumberOfGames(MatchRequest request) =>
        PlayGames(request, matchRequest =>
            matchRequest.Match.GameHistory.Count < matchRequest.Match.FixedNumberOfGames
            && !MatchIsOver(matchRequest.Match)
        );

    private async Task<MatchResponse> PlayIndefinitely(MatchRequest request)
    {
        return await PlayGames(request, matchRequest =>
        {
            if(MatchIsOver(matchRequest.Match))
                return false;
            return _gamePreferencesService
                .GetPlayAgain(matchRequest.Match.GameHistory.LastOrDefault()?.Variant.Name ?? matchRequest.Match.FixedVariant.Name)
                .GetAwaiter()
                .GetResult();
        });
    }

    /// <summary>
    /// The match is over when only one player has money left, or when the human player has run out of money.
    /// </summary>
    private static readonly Predicate<Match> MatchIsOver = match =>
        match.Players.NotBusted().Count <= 1
        || HumanPlayerIsBusted!(match);

    private static readonly Predicate<Match> HumanPlayerIsBusted = match =>
        match.Players.Any(p => !p.Automaton && p.Busted);

    private static List<Player> UpdatePlayers(
        IReadOnlyList<Participant> participantsInGame,
        IReadOnlyList<Player> playersInMatch
    )
    {
        var participants = participantsInGame.ToDictionary(p => p.Id, p => p);

        var playersOut = new List<Player>();

        foreach (var player in playersInMatch)
        {
            if (!participants.TryGetValue(player.Id, out var playerInGame))
            {
                playersOut.Add(player);
                continue;
            }
            playersOut.Add(player with
            {
                Stack = playerInGame.Stack,
                Busted = playerInGame.Busted
            });
        }
        return playersOut;
    }

    private Task WriteMatchStartInfoAsync(Match match)
    {
        _userInterfaceService.WriteHeading(HeadingLevel.Two, "Welcome to the new match!");

        _userInterfaceService.WriteList("Players:", match.Players.Select(x => x.Name).ToArray());

        _userInterfaceService.WriteHeading(HeadingLevel.Three, $"The match type is {match.FixedVariant.Name}");

        _userInterfaceService.WriteLine(
            match.FixedNumberOfGames.HasValue()
            ? $"The match will consist of {match.FixedNumberOfGames} games."
            : "The match has no fixed number of games."
        );

        return Task.CompletedTask;
    }

    private Task WriteMatchEndInfoAsync(MatchResponse response)
    {
        _userInterfaceService.WriteHeading(HeadingLevel.Two, "The match is over!");

        if (HumanPlayerIsBusted(response.Match))
            _userInterfaceService.WriteLine("You ran out of money.");

        _userInterfaceService.WriteList(
            response.Winners.Count > 1 ? "Winners" : "Winner",
            response.Winners.Select(w => $"{w.Name}: {w.Stack:C0}")
        );

        return Task.CompletedTask;
    }

    public async Task<MatchResponse> PlayAsync(MatchRequest request)
    {
        await WriteMatchStartInfoAsync(request.Match);

#if DEBUG
        Console.WriteLine($"Total money in play: {request.Match.TotalMoneyInPlay:C0}");
        Console.WriteLine("Total money in play should never change. If it changes, something went wrong.");
#endif

        var resultTask =
            await _matchPreferencesService.ConfirmStartAsync() switch
            {
                false => CancelMatchAsync(request.Match),
                true =>
                    EvaluateResult(
                        await
                        (
                            request.Match.FixedNumberOfGames switch
                            {
                                > 0 => PlayFixedNumberOfGames(request),
                                _ => PlayIndefinitely(request)
                            }
                        )
                    )
            };

        return await resultTask;
    }

    private async Task<MatchResponse> CancelMatchAsync(Match match)
    {
        _userInterfaceService.WriteLine("Match was cancelled.");
        return new MatchResponse
        {
            Cancelled = true,
            Match = match,
            Winners = [],
            PlayAgain = await _matchPreferencesService.GetPlayAgain(match)
        };
    }

    private async Task<MatchResponse> EvaluateResult(MatchResponse responseIn)
    {
        await WriteMatchEndInfoAsync(responseIn);

        return new()
        {
            Cancelled = false,
            Match = responseIn.Match,
            Winners = responseIn.Winners,
            PlayAgain = await _matchPreferencesService.GetPlayAgain(responseIn.Match)
        };
    }
}
