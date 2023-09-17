namespace Poker.Domain.Implementations.HandQualifiers;

public static partial class HandQualifierDelegates
{
    public static HandQualifier FlushHandQualifier { get; } =
        (Hand hand, List<Card> cards, uint remainingCardCount) =>
    {
        var maxCardsWithSameSuit = 0;

        foreach(var suit in Suits.All.OrderByDescending(s => s.Priority))
        {
            var cardsWithSuit = cards
                .Where(c => c.MatchesSuitOrIsWild(suit))
                .OrderBy(c => c.IsWild)
                .ThenByDescending(c => c.Rank)
                .ToList();

            if(cardsWithSuit.Count > maxCardsWithSameSuit)
                maxCardsWithSameSuit = cardsWithSuit.Count;

            if (cardsWithSuit.Count < GlobalConstants.HandSize)
                continue;

            return cards.ToQualifiedHand(
                cardsWithSuit.Take(5).ToList(),
                hand
            );
        }

        return cards.ToUnqualifiedHand(
            hand,
            maxCardsWithSameSuit + remainingCardCount >= GlobalConstants.HandSize
        );
    };
}
