namespace Poker.Service;

public class MatchService : IMatchService
{
    private readonly IMatchPreferencesService _matchPreferencesService;

    private readonly IGamePreferencesService _gamePreferencesService;

    private readonly IGameService _gameService;

    private readonly IUserInterfaceService _userInterfaceService;

    public MatchService(
        IMatchPreferencesService matchPreferencesService,
        IGamePreferencesService gamePreferencesService,
        IGameService gameService,
        IUserInterfaceService userInterfaceService
        )
    {
        _matchPreferencesService = matchPreferencesService ?? throw new ArgumentNullException(nameof(matchPreferencesService));
        _gamePreferencesService = gamePreferencesService ?? throw new ArgumentNullException(nameof(gamePreferencesService));
        _gameService = gameService ?? throw new ArgumentNullException(nameof(gameService));
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
    }

    private async Task<MatchResponse> PlayFixedNumberOfGames(MatchRequest request)
    {
        var gamesOut = request.Match.Games;
        var playersOut = request.Match.Players;

        while (request.Match.Games.Count < request.Match.FixedNumberOfGames!.Value)
        {
            var gameResponse = await FacilitateGameAsync(
                new GameRequest
                {
                    Match = request.Match,
                    Players = playersOut,
                    Variant = request.Match.FixedVariant!,
                    Deck = request.Match.FixedDeck!,
                    Button = request.InitialButton
                }
            );
            WriteStandings(gameResponse);
            gamesOut.Add(gameResponse);
            playersOut = gameResponse.Players;
        }

        return new MatchResponse
        {
            Cancelled = false,
            Match = request.Match with { Players = playersOut },
            Winners = playersOut.GetRichest(),
            PlayAgain = gamesOut.Count < request.Match.FixedNumberOfGames!.Value
        };
    }

    private void WriteStandings(GameResponse request)
    {
        _userInterfaceService.WriteHeading(HeadingLevel.Five, "Standings");
        foreach (var player in request.Match.Players.OrderByDescending(p => p.Stack))
            _userInterfaceService.WriteLine($"{player.Name} - {player.Stack:C}");
        _userInterfaceService.WriteLine();
    }

    private async Task<MatchResponse> PlayIndefinitely(MatchRequest request)
    {
        var gamesOut = request.Match.Games;
        var playersOut = request.Match.Players;

        var keepPlaying = true;
        while (keepPlaying)
        {
            var gameResponse = await FacilitateGameAsync(new GameRequest { 
                Match = request.Match,
                Players = request.Match.Players,
                Variant = request.Match.FixedVariant!,
                Deck = request.Match.FixedDeck!,
                Button = request.Match.Button
            });

            WriteStandings(gameResponse);

            keepPlaying =
                await _gamePreferencesService.GetPlayAgain(gameResponse);

            gamesOut.Add(gameResponse);
            playersOut = gameResponse.Players;
        }

        return new MatchResponse
        {
            Cancelled = false,
            Match = request.Match with { Players = playersOut },
            Winners = playersOut.GetRichest(),
            PlayAgain = gamesOut.Count < request.Match.FixedNumberOfGames!.Value
        };
    }

    protected Task WriteMatchStartInfoAsync(Match match)
    {
        var s = _userInterfaceService;

        s.WriteHeading(HeadingLevel.Two, "Welcome to the new match!");

        s.WriteList("Players:", match.Players.Select(x => x.Name).ToArray());

        s.WriteHeading(HeadingLevel.Three, $"The match type is {match.FixedVariant?.Name ?? "Dealer's Choice"}");

        if (match.FixedNumberOfGames.HasValue)
            s.WriteLine($"The match will consist of {match.FixedNumberOfGames} games.");
        else
            s.WriteLine($"The match has no fixed number of games.");

        return Task.CompletedTask;
    }

    public async Task<MatchResponse> PlayAsync(MatchRequest request)
    {
        await WriteMatchStartInfoAsync(request.Match);

        var resultTask =
            await _matchPreferencesService.ConfirmStartAsync() switch
            {
                false => CancelMatchAsync(request.Match),
                true =>
                    EvaluateResult(
                        await (request.Match.FixedNumberOfGames.HasValue switch
                        {
                            true => PlayFixedNumberOfGames(request),
                            false => PlayIndefinitely(request)
                        })
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
            Winners = new(),
            PlayAgain = await _matchPreferencesService.GetPlayAgain(match)
        };
    }

    /// <summary>
    /// IS THIS METHOD DOING ANYTHING THAT SHOULDN'T BE DONE BY GAMESERVICE ?
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    protected async Task<GameResponse> FacilitateGameAsync(GameRequest request)
    {
        var matchOut = request.Match;
        var gamesOut = matchOut.Games;
        var playersOut = matchOut.Players;

        _userInterfaceService
            .WriteHeading(HeadingLevel.Four, $"Starting game {matchOut.Games.Count + 1}");

        // pass button to next player if it's not the first game
        var button = gamesOut.Any()
            ? matchOut.Players.NextPlayer(matchOut.Button)
            : matchOut.Button;

        var gameResponse = await _gameService.PlayAsync(
            new GameRequest()
            {
                Match = matchOut,
                Players = playersOut,
                Variant = matchOut.FixedVariant ?? (await _gamePreferencesService.GetVariant(button)),
                Deck = matchOut.FixedDeck ?? (await _gamePreferencesService.GetDeck(button)),
                Button = button
            }
        );

        playersOut = gameResponse.Players;
        gamesOut.Add(gameResponse);

        _userInterfaceService
            .WriteHeading(HeadingLevel.Four, $"Game over! TBD wins.");

        return new MatchMessage {
            Match = matchOut with
            {

                Games = gamesOut,
                Players = playersOut,
                Button = button
            },
            LastButton = button
        };
    }

    protected async Task<MatchResponse> EvaluateResult(MatchResponse responseIn) => 
        new MatchResponse()
        {
            Cancelled = false,
            Match = responseIn.Match,
            Winners = new(),
            PlayAgain = await _matchPreferencesService.GetPlayAgain(responseIn.Match)
        };
}
