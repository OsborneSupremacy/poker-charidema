namespace Poker.Service;

public class MatchService : IMatchService
{
    private readonly IMatchPreferencesService _matchPreferencesService;

    private readonly IGamePreferencesService _gamePreferencesService;

    private readonly IGameService _gameService;

    public MatchService(
        IMatchPreferencesService matchPreferencesService,
        IGamePreferencesService gamePreferencesService,
        IGameService gameService
        )
    {
        _matchPreferencesService = matchPreferencesService ?? throw new ArgumentNullException(nameof(matchPreferencesService));
        _gamePreferencesService = gamePreferencesService ?? throw new ArgumentNullException(nameof(gamePreferencesService));
        _gameService = gameService ?? throw new ArgumentNullException(nameof(gameService));
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

    public async Task<MatchResult> PlayAsync(MatchArgs args)
    {
        Match match = new()
        {
            FixedNumberOfGames = args.FixedNumberOfGames,
            FixedVariant = args.FixedVariant,
            FixedDeck = args.FixedDeck,
            Players = new(),
            Games = new(),
            Button = args.InitialButton
        };

        await (args.FixedNumberOfGames.HasValue switch
        {
            true => PlayFixedNumberOfGames(match),
            _ => PlayIndefinitely(match)
        });

        return await EvaluateResult(match);
    }

    protected async Task<Match> PlayGameAsync(Match matchIn)
    {
        // pass button to next player if it's not the first game
        Player button = matchIn.Games.Any()
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
                Match = matchIn,
                Winners = new(),
                PlayAgain = await _matchPreferencesService.GetPlayAgain()
            };
    }
}
