using Poker.Library.Cards;

namespace Poker.Library.Hands;

public class TwoPair : IHandRanking
{
    public string Name => "Two Pair";

    public uint Value => 30;

    public int RequiredMatches => 2;

    public IPartialHandRankingResult QualifyPartial(IDeck deck, List<ICard> playerCards)
    {
        var (qualifies, firstPair, secondPair) = GetQualifyingRank(deck, playerCards);

        if (!qualifies)
            return new PartialHandRankingResult
            {
                Qualifies = false,
                HandCards = new(),
                NonHandCards = new()
            };

        var handCards = firstPair.Union(secondPair).ToList();

        return new PartialHandRankingResult
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
        var firstPairResult = new Pair().QualifyPartial(deck, playerCards);

        if (!firstPairResult.Qualifies)
            return (false, new(), new());

        var remainingCards = firstPairResult.NonHandCards;
        var secondPairResult = new Pair().QualifyPartial(deck, remainingCards);

        if (!secondPairResult.Qualifies)
            return (false, new(), new());

        return (true, firstPairResult.HandCards, secondPairResult.HandCards);
    }
}
