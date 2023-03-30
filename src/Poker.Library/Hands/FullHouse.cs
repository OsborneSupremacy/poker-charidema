using Poker.Library.Cards;

namespace Poker.Library.Hands;

public class FullHouse : IHandRanking
{
    public string Name => "Full House";

    public uint Value => 70;

    public IHandRankingResult Qualify(IDeck deck, List<ICard> playerCards)
    {
        var threeOfAKind = new ThreeOfAKind().QualifyPartial(deck, playerCards);

        if (!threeOfAKind.Qualifies)
            return new HandRankingResult
            {
                Qualifies = false,
                HandCards = new(),
                Kickers = new(),
                DeadCards = new()
            };

        var remainingCards = threeOfAKind.NonHandCards;

        var pair = new Pair().QualifyPartial(deck, remainingCards);

        if (!pair.Qualifies)
            return new HandRankingResult
            {
                Qualifies = false,
                HandCards = new(),
                Kickers = new(),
                DeadCards = new()
            };

        var handCards = threeOfAKind.HandCards
            .Union(pair.HandCards)
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

    public IPartialHandRankingResult QualifyPartial(IDeck deck, List<ICard> playerCards) => throw new NotImplementedException();
}
