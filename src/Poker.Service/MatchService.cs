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

    private async Task<Match> PlayFixedNumberOfGames(Match match)
    {
        while (match.Games.Count < match.FixedNumberOfGames)
        {
            match = await PlayGameAsync(match);
            WriteStandings(match);
        }
        return match;
    }

    private void WriteStandings(Match match)
    {
        _userInterfaceService.WriteHeading(HeadingLevel.Five, "Standings");
        foreach (var player in match.Players.OrderByDescending(p => p.Stack))
            _userInterfaceService.WriteLine($"{player.Name} - {player.Stack:C}");
    }

    private async Task<Match> PlayIndefinitely(Match match)
    {
        var keepPlaying = true;
        while (keepPlaying)
        {
            var matchOut = await PlayGameAsync(match);

            WriteStandings(matchOut);

            keepPlaying =
                await _gamePreferencesService.GetPlayAgain(matchOut.Games.Last());

            match = matchOut;
        }
        return match;
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

    public async Task<MatchResult> PlayAsync(MatchArgs args)
    {
        Match match = new()
        {
            FixedNumberOfGames = args.FixedNumberOfGames,
            FixedVariant = args.FixedVariant,
            FixedDeck = args.FixedDeck,
            Players = args.Players,
            Games = new(),
            Button = args.InitialButton,
            AntePreferences = args.AntePreferences,
            StartingStack = args.StartingStack
        };

        await WriteMatchStartInfoAsync(match);

        Task<MatchResult> resultTask = 
            await _matchPreferencesService.ConfirmStartAsync() switch
            {
                false => CancelMatchAsync(match),
                true =>
                    EvaluateResult(
                        await (args.FixedNumberOfGames.HasValue switch
                        {
                            true => PlayFixedNumberOfGames(match),
                            false => PlayIndefinitely(match)
                        })
                    )
            };

        return await resultTask;
    }

    private async Task<MatchResult> CancelMatchAsync(Match match)
    {
        _userInterfaceService.WriteLine("Match was cancelled.");
        return new MatchResult
        {
            Cancelled = true,
            Match = match,
            Winners = new(),
            PlayAgain = await _matchPreferencesService.GetPlayAgain(match)
        };
    }

    protected async Task<Match> PlayGameAsync(Match matchIn)
    {
        _userInterfaceService
            .WriteHeading(HeadingLevel.Four, $"Starting game {matchIn.Games.Count + 1}");

        // pass button to next player if it's not the first game
        var button = matchIn.Games.Any()
            ? matchIn.Players.NextPlayer(matchIn.Button)
            : matchIn.Button;

        var gameOut = await _gameService.PlayAsync(
            new GameArgs()
            {
                Match = matchIn,
                Players = matchIn.Players,
                Variant = matchIn.FixedVariant ?? (await _gamePreferencesService.GetVariant(button)),
                Deck = matchIn.FixedDeck ?? (await _gamePreferencesService.GetDeck(button)),
                Button = button
            }
        );

        Match matchOut = matchIn with
        {
            Games = matchIn.Games.Append(gameOut).ToList(),
            Players = gameOut.Players.Select(x => x.Player).ToList(),
            Button = button
        };

        _userInterfaceService
            .WriteHeading(HeadingLevel.Four, $"Game over! TBD wins.");

        return matchOut;
    }

    protected async Task<MatchResult> EvaluateResult(Match matchIn) => 
        new MatchResult()
        {
            Cancelled = false,
            Match = matchIn,
            Winners = new(),
            PlayAgain = await _matchPreferencesService.GetPlayAgain(matchIn)
        };
}
