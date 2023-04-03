using Poker.Library.Cards;

namespace Poker.Library.Hands;

public class FullHouse : IHandRanking
{
    public string Name => "Full House";

    public uint Value => 70;

    public IHandRankingResult Qualify(IHandRankingArgs args)
    {
        var playerCards = args.PlayerCards;

        var threeOfAKind = new ThreeOfAKind().QualifyPossible(args);

        if (!threeOfAKind.Qualifies)
            return new NoHand().Qualify(args);

        var remainingCards = threeOfAKind.NonHandCards;

        var pair = new Pair().QualifyPossible(
            new HandRankingArgs
            {
                Deck = args.Deck,
                PlayerCards = remainingCards
            }
        );

        if (!pair.Qualifies)
            return new NoHand().Qualify(args);

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
}
