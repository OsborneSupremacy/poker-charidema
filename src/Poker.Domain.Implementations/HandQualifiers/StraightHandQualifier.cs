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
                    GlobalConstants.HandSize - all.Select(x => x.Cards.Count).Max()
                )
            );

        return complete.Count switch
        {
            1 => cards.ToQualifiedHand(hand, complete.Single().Cards),
            _ => cards.ToQualifiedHand(hand, GetBestStraightResult(complete).Cards)
        };
    };

    private static StraightResult GetBestStraightResult(
        List<StraightResult> straightResults
        )
    {
        foreach (var rank in Ranks.All.OrderByDescending(x => x.Value))
        {
            var straight = GetStraightResultWithRank(straightResults, rank);
            if (straight.Complete)
                return straight;
        }
        return new()
        {
            Complete = false,
            Cards = new()
        };
    }

    private static StraightResult GetStraightResultWithRank(
        List<StraightResult> straights,
        Rank rank
        )
    {
        foreach (var straight in straights)
        {
            if (straight.Cards.Any(x => x.MatchesRankOrIsWild(rank)))
                return straight;
        }
        return new StraightResult
        {
            Complete = false,
            Cards = new()
        };
    }

    private static List<StraightResult> EvaluateStraights(List<Card> cards) =>
        Ranks
            .All
            .Where(r => r.Value <= 10)
            .OrderBy(x => x.Value)
            .Select(x => EvalulateStraightStartingWith(x, cards))
            .ToList();

    private static StraightResult EvalulateStraightStartingWith(
        Rank startingRank,
        List<Card> cards
        )
    {
        List<Card> sequence = new();
        List<Card> unusedCards = new();
        unusedCards.AddRange(cards);

        for (int r = 0; r < GlobalConstants.HandSize; r++)
        {
            var cardInSeqeuence = unusedCards
                .Where(c => c.MatchesRankOrIsWild(
                    Ranks.All[startingRank.Value.ToInt() + r])
                )
                .OrderBy(c => c.IsWild) // prefer non-wild
                .ThenByDescending(c => c.Suit.Priority)
                .FirstOrDefault() ?? Cards.Empty;

            if (cardInSeqeuence == Cards.Empty)
                return new StraightResult
                {
                    Complete = false,
                    Cards = sequence
                };

            sequence.Add(cardInSeqeuence);
            unusedCards.Remove(cardInSeqeuence);
        }

        return new StraightResult {
            Complete = true,
            Cards = sequence
        };
    }

    private record StraightResult
    {
        public required bool Complete { get; init; }

        public required List<Card> Cards { get; init; }
    }
}
