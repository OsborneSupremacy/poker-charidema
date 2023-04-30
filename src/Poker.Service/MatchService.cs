using Poker.Presentation.Interface;

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
            match = await PlayGameAsync(match);
        return match;
    }

    private async Task<Match> PlayIndefinitely(Match match)
    {
        var keepPlaying = true;
        while (keepPlaying)
        {
            match = await PlayGameAsync(match);
            keepPlaying = await _matchPreferencesService.GetPlayAgain();
        }
        return match;
    }

    protected Task WriteMatchStartInfoAsync(Match match)
    {
        var s = _userInterfaceService;

        s.WriteHeading(1, "Welcome to the new match!");

        s.WriteList("Players:", match.Players.Select(x => x.Name).ToArray());

        s.WriteHeading(2, $"The match type is {match.FixedVariant?.Name ?? "Dealer's Choice"}");

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
            Button = args.InitialButton
        };

        await WriteMatchStartInfoAsync(match);

        if (!await _matchPreferencesService.ConfirmStartAsync())
        {
            _userInterfaceService.WriteLine("Match was cancelled.");
            return new MatchResult
            {
                Cancelled = true,
                Match = match,
                Winners = new(),
                PlayAgain = await _matchPreferencesService.GetPlayAgain()
            };
        }

        await (args.FixedNumberOfGames.HasValue switch
        {
            true => PlayFixedNumberOfGames(match),
            _ => PlayIndefinitely(match)
        });

        return await EvaluateResult(match);
    }

    protected async Task<Match> PlayGameAsync(Match matchIn)
    {
        _userInterfaceService
            .WriteHeading(2, $"Stating game {matchIn.Games.Count + 1}");

        // pass button to next player if it's not the first game
        IPlayer button = matchIn.Games.Any()
            ? matchIn.Players.NextPlayer(matchIn.Button)
            : matchIn.Button;

        var game = await _gameService.PlayAsync(
            new GameArgs()
            {
                Players = matchIn.Players,
                Variant = matchIn.FixedVariant ?? (await _gamePreferencesService.GetVariant(button)),
                Deck = matchIn.FixedDeck ?? (await _gamePreferencesService.GetDeck(button)),
                Button = button
            }
        );

        Match matchOut = matchIn with
        {
            Games = matchIn.Games.Append(game).ToList(),
            Button = button
        };

        return matchOut;
    }

    protected async Task<MatchResult> EvaluateResult(Match matchIn)
    {
        return
            new MatchResult()
            {
                Cancelled = false,
                Match = matchIn,
                Winners = new(),
                PlayAgain = await _matchPreferencesService.GetPlayAgain()
            };
    }
}
