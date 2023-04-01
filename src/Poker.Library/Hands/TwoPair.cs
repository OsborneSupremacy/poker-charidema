using Poker.Library.Cards;

namespace Poker.Library.Hands;

public class TwoPair : IHandRanking, IPossibleHandRanking
{
    public string Name => "Two Pair";

    public uint Value => 30;

    public int RequiredMatches => 2;

    public IPossibleHandrankingResult QualifyPossible(IDeck deck, List<ICard> playerCards)
    {
        var (qualifies, firstPair, secondPair) = GetQualifyingRank(deck, playerCards);

        if (!qualifies)
            return new PossibleRankHandingResult
            {
                Qualifies = false,
                HandCards = new(),
                NonHandCards = new()
            };

        var handCards = firstPair.Union(secondPair).ToList();

        return new PossibleRankHandingResult
        {
            Qualifies = true,
            HandCards = firstPair.Union(secondPair).ToList(),
            NonHandCards = playerCards.Except(handCards).ToList()
        };
    }

    public IHandRankingResult Qualify(IDeck deck, List<ICard> playerCards)
    {
        var (qualifies, firstPair, secondPair) = GetQualifyingRank(deck, playerCards);

        if (!qualifies)
            return new HandRankingResult
            {
                Qualifies = false,
                HandCards = new(),
                Kickers = new(),
                DeadCards = new()
            };

        var handCards = firstPair
            .Union(secondPair)
            .ToList();

        var kickers = playerCards.GetKickers(handCards, 5);

        return new HandRankingResult
        {
            Qualifies = true,
            HandCards = handCards,
            Kickers = kickers,
            DeadCards = playerCards.GetDeadCards(handCards, kickers)
        };
    }

    private (bool qualifies, List<ICard> firstPair, List<ICard> secondPair) GetQualifyingRank(IDeck deck, List<ICard> playerCards)
    {
        var firstPairResult = new Pair().QualifyPossible(deck, playerCards);

        if (!firstPairResult.Qualifies)
            return (false, new(), new());

        var remainingCards = firstPairResult.NonHandCards;
        var secondPairResult = new Pair().QualifyPossible(deck, remainingCards);

        if (!secondPairResult.Qualifies)
            return (false, new(), new());

        return (true, firstPairResult.HandCards, secondPairResult.HandCards);
    }
}
