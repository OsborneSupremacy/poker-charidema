namespace Poker.Domain.Implementations.HandQualifiers;

public static partial class HandQualifierDelegates
{
    public static HandQualifier StraightHandQualifier { get; } =
        (Hand hand, List<Card> cards, uint remainingCardCount) =>
    {
        var all = EvaluateStraights(cards);
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
            GetBestStraight(complete).Cards
        );
    };

    private static EvalulatedStraight GetBestStraight(
        List<EvalulatedStraight> evalulated
        ) =>
        evalulated
            .Where(x => x.HighRank.Value == evalulated.Max(x => x.HighRank.Value))
            .OrderByDescending(x => x.Cards.First().Suit.Priority)
            .First();

    private static List<EvalulatedStraight> EvaluateStraights(List<Card> cards) =>
        Ranks
            .All
            .Where(r => r.Value <= 10)
            .OrderBy(x => x.Value)
            .Select(x => EvalulateStraight(x, cards))
            .ToList();

    private static EvalulatedStraight EvalulateStraight(
        Rank startingRank,
        List<Card> cards
        )
    {
        Rank highRank = Ranks.Empty;
        List<Card> sequence = new();
        List<Card> unusedCards = new();
        unusedCards.AddRange(cards);

        for (int r = 0; r < GlobalConstants.HandSize; r++)
        {
            var rank = Ranks.All[startingRank.Value.ToInt() + r];

            var cardInSeqeuence = unusedCards
                .Where(c => c.MatchesRankOrIsWild(rank))
                .OrderBy(c => c.IsWild) // prefer non-wild
                .ThenByDescending(c => c.Suit.Priority)
                .FirstOrDefault() ?? Cards.Empty;

            if (cardInSeqeuence == Cards.Empty)
                return new EvalulatedStraight
                {
                    HighRank = highRank,
                    Complete = false,
                    Cards = sequence
                };

            highRank = rank;
            sequence.Add(cardInSeqeuence);
            unusedCards.Remove(cardInSeqeuence);
        }

        return new EvalulatedStraight {
            HighRank = highRank,
            Complete = true,
            Cards = sequence
        };
    }

    private record EvalulatedStraight
    {
        public required Rank HighRank { get; init; }

        public required bool Complete { get; init; }

        public required List<Card> Cards { get; init; }
    }
}
