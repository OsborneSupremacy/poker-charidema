namespace Poker.Service;

public class MatchService
{
    private readonly Match _match;

    private readonly Deck _deck;

    private readonly Rounds _handService;

    public MatchService(
        List<Player> players,
        Deck deck,
        Rounds handService
        )
    {
        _match = new Match()
        {
            Players = players,
            Games = new()
        };
        _deck = deck ?? throw new ArgumentNullException(nameof(deck));
        _handService = handService ?? throw new ArgumentNullException(nameof(handService));
    }

    public async Task<MatchResult> PlayAsync()
    {
        //BuildDeck();
        //Shuffle();
        //PromptForAnte();
        //Deal();
        //AcceptBets();

        //List<Player> winners = EvaluateWinners();

        //if(winners.Any())
        //    return (winners, _match.po // should be game's pot

        //foreach(var round)

        //while(
        //    _match
        //        .Players
        //        .Where(p => p.IsInHand).Count() > 1)
        //    _handService.Play();

        //return _match.
        //    Players
        //    .Where(p => p.IsInHand)
        //    .Single();

        Match match = new()
        {

        };




        while(match.FixedNumberOfGames.HasValue && match.Games.Count < match.FixedNumberOfGames)
        {
            await PlayGameAsync();
        };

        if(!match.FixedNumberOfGames.HasValue)
        {
            await PlayGameAsync();
        }

        return new MatchResult();
    }

    protected Task<Game> PlayGameAsync()
    {
        return Task.FromResult(new Game());
    }

    protected Task<List<Player>> DetermineWinners()
    {
        return Task.FromResult(new List<Player>());
    }

}
