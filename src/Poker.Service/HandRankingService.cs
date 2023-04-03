using Poker.Library.Hands;

namespace Poker.Service;

public class HandRankingService
{
    private IEnumerable<IHandRanking> _getHandRankings()
    {
        yield return new FiveOfAKind();
        yield return new RoyalFlush();
        yield return new StraightFlush();
        yield return new FourOfAKind();
        yield return new FullHouse();
        yield return new Flush();
        yield return new Straight();
        yield return new ThreeOfAKind();
        yield return new TwoPair();
        yield return new Pair();
        yield return new HighCard();
    }

    public IBestHandRankingResult GetBest(IHandRankingArgs args)
    {
        foreach(var handRanking in _getHandRankings())
        {
            var result = handRanking.Qualify(args);
            if (result.Qualifies)
                return new BestHandRankingResult
                {
                    HandRanking = handRanking,
                    HandRankingResult = result
                };
        }

        NoHand noHand = new();

        return new BestHandRankingResult
        {
            HandRanking = noHand,
            HandRankingResult = noHand.Qualify(args)
        };
    }
}
