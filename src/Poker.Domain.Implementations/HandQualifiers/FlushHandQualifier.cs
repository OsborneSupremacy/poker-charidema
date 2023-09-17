namespace Poker.Domain.Implementations.HandQualifiers;

public static partial class HandQualifierDelegates
{
    public static HandQualifier FlushHandQualifier { get; } =
        (Hand hand, List<Card> cards, uint remainingCardCount) =>
    {
        HashSet<int> potentialFlushCount = new();

        foreach(var suit in Suits.All.OrderByDescending(s => s.Priority))
        {
            var cardsWithSuit = cards
                .Where(c => c.MatchesSuitOrIsWild(suit))
                .OrderBy(c => c.IsWild)
                .ThenByDescending(c => c.Rank)
                .ToList();

            potentialFlushCount.Add(cardsWithSuit.Count);

            if (cardsWithSuit.Count < GlobalConstants.HandSize)
                continue;

            return cards.ToQualifiedHand(
                hand,
                cardsWithSuit.Take(GlobalConstants.HandSize).ToList()
            );
        }

        return cards.ToUnqualifiedHand(
            hand,
            potentialFlushCount.Max() + remainingCardCount >= GlobalConstants.HandSize
        );
    };
}
