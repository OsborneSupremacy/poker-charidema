namespace Poker.Domain.Implementations.HandQualifiers;

public static partial class HandQualifierDelegates
{
    public static HandQualifier FlushHandQualifier { get; } =
        (Hand hand, List<Card> cards, uint remainingCardCount) =>
    {
        var all = EvaluateFlushes(cards);
        var complete = all.Where(x => x.Complete).ToList();

        if (!complete.Any())
            return cards.ToUnqualifiedHand(
                hand,
                remainingCardCount >= (
                    GlobalConstants.HandSize - all.Max(x => x.Cards.Count)
                )
            );

        return cards.ToQualifiedHand(
            hand,
            GetBestFlush(complete).Cards
        );
    };

    private static EvalulatedFlush GetBestFlush(
        List<EvalulatedFlush> evalulated
        ) =>
        evalulated
            .Where(x => x.Suit.Priority == evalulated.Max(x => x.Suit.Priority))
            .OrderByDescending(x => x.Cards.Max(c => c.IsWild))
            .ThenByDescending(x => x.Cards.Max(c => c.Rank.Value))
            .First();

    private static List<EvalulatedFlush> EvaluateFlushes(List<Card> cards) =>
        Suits
            .All
            .OrderByDescending(s => s.Priority)
            .Select(s => EvalulateFlushWithSuit(s, cards))
            .ToList();

    private static EvalulatedFlush EvalulateFlushWithSuit(
        Suit suit,
        List<Card> cards
        )
    {
        var cardsWithSuit = cards
            .Where(c => c.MatchesSuitOrIsWild(suit))
            .OrderBy(c => c.IsWild)
            .ThenByDescending(c => c.Rank)
            .Take(GlobalConstants.HandSize)
            .ToList();

        return new EvalulatedFlush
        {
            Suit = suit,
            Complete = cardsWithSuit.Count >= GlobalConstants.HandSize,
            Cards = cardsWithSuit
        };
    }

    private record EvalulatedFlush
    {
        public required Suit Suit { get; init; }

        public required bool Complete { get; init; }

        public required List<Card> Cards { get; init; }
    }
}
