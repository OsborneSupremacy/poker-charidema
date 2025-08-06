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
        Func<int, bool> keepPlayingGamesCondition
        )
    {
        var gameHistory = request.Match.GameHistory.ToList();
        var playersWorking = request.Match.Players;

        var keepPlaying = true;

        while (keepPlaying)
        {
            var coordinatedGameResponse = await _gameCoordinator.ExecuteAsync(
                new CoordinateGameRequest
                {
                    Match = request.Match,
                    Players = playersWorking,
                    Variant = request.Match.FixedVariant,
                    Deck = request.Match.FixedDeck,
                    InitialButtonId = request.InitialButton.Id,
                    GameHistory = gameHistory
                }
            );

            gameHistory.Add(coordinatedGameResponse.GameResponse);
            playersWorking = UpdatePlayers(coordinatedGameResponse.GameResponse.Participants, playersWorking);
            keepPlaying = keepPlayingGamesCondition(gameHistory.Count);
        }

        return new MatchResponse
        {
            Cancelled = false,
            Match = request.Match with
            {
                GameHistory = gameHistory,
                Players = playersWorking
            },
            Winners = playersWorking.Richest(),
            PlayAgain = false // need to create match preferences service to handle this
        };
    }

    private Task<MatchResponse> PlayFixedNumberOfGames(MatchRequest request) =>
        PlayGames(request, gameCount => gameCount < request.Match.FixedNumberOfGames);

    private async Task<MatchResponse> PlayIndefinitely(MatchRequest request) =>
        await PlayGames(request, _ => _gamePreferencesService
            .GetPlayAgain(request.Match.GameHistory.LastOrDefault()?.Variant.Name ?? request.Match.FixedVariant.Name)
            .GetAwaiter()
            .GetResult()
        );

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

        _userInterfaceService.WriteList("ParticipatingPlayers:", match.Players.Select(x => x.Name).ToArray());

        _userInterfaceService.WriteHeading(HeadingLevel.Three, $"The match type is {match.FixedVariant.Name}");

        _userInterfaceService.WriteLine(
            match.FixedNumberOfGames.HasValue()
            ? $"The match will consist of {match.FixedNumberOfGames} games."
            : "The match has no fixed number of games."
        );

        return Task.CompletedTask;
    }

    public async Task<MatchResponse> PlayAsync(MatchRequest request)
    {
        await WriteMatchStartInfoAsync(request.Match);

#if DEBUG
        Console.WriteLine($"Total money in play: {request.Match.TotalMoneyInPlay}");
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

    private async Task<MatchResponse> EvaluateResult(MatchResponse responseIn) =>
        new()
        {
            Cancelled = false,
            Match = responseIn.Match,
            Winners = [],
            PlayAgain = await _matchPreferencesService.GetPlayAgain(responseIn.Match)
        };
}
