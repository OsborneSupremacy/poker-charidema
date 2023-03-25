namespace Poker.Service;

public class MatchService
{

    private readonly IUiService _uiService;

    private readonly IGameService _gameService;


    private async Task PlayFixedNumberOfGames(Match match)
    {
        while (match.Games.Count < match.FixedNumberOfGames)
            match = await PlayGameAsync(match);
        return;
    }

    private async Task PlayIndefinitely(Match match)
    {
        while (
            match.Games.Count == 0 // don't prompt to play again if it's the first game
            || await _uiService.PromptToPlayAgainAsync(match.Games.Count)
            )
            match = await PlayGameAsync(match);
        return;
    }

    public async Task<MatchResult> PlayAsync(Match match)
    {
        await (match.FixedNumberOfGames.HasValue switch
        {
            true => PlayFixedNumberOfGames(match),
            _ => PlayIndefinitely(match)
        });

        return await EvaluateResult(match);
    }

    protected async Task<Match> PlayGameAsync(Match matchIn)
    {
        Player button = matchIn.Players[0]; // TODO: make random

        var variant = matchIn.FixedVariant ??  (await _uiService.PromptForVariant(button));

        var game = await _gameService.PlayAsync(
            new GameArgs()
            {
                Players = matchIn.Players,
                Variant = variant,
                Deck = null,
                Button = matchIn.Players[0] 
            }
        );

        List<Game> gamesOut = matchIn.Games;
        gamesOut.Add(game);

        Match matchOut = matchIn with
        {
            Games = gamesOut
        };

        return matchOut;
    }

    protected Task<MatchResult> EvaluateResult(Match matchIn)
    {
        return Task.FromResult(
            new MatchResult() {
                Match = matchIn,
                Winners = new()
            }
        );
    }

}
