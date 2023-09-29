namespace Poker.Domain.Implementations;

public static partial class HandQualifierDelegates
{
    public static HandQualifier StraightHandQualifier { get; } =
        (QualifiedHandRequest request) =>
    {
        var all = EvaluateStraights(request.Cards);
        var complete = all.Where(x => x.Complete).ToList();

        if (!complete.Any())
            return request.Cards.ToUnqualifiedHand(
                request.Hand,
                all.EnoughRemainingCards(request.RemainingCardCount)
            );

        return request.Cards.ToQualifiedHand(
            request.Hand,
            GetBestStraight(complete).Cards
        );
    };

    private static PotentialHandMessage GetBestStraight(
        List<PotentialHandMessage> evalulated
        ) =>
        evalulated
            .Where(x => x.HighRank.Value == evalulated.Max(x => x.HighRank.Value))
            .OrderByDescending(x => x.Cards.First().Suit.Priority)
            .First();

    private static List<PotentialHandMessage> EvaluateStraights(List<Card> cards) =>
        Ranks.All
            .Where(r => r.Value <= Ranks.Ten.Value)
            .OrderBy(x => x.Value)
            .Select(x => EvalulateStraight(x, cards))
            .ToList();

    private static PotentialHandMessage EvalulateStraight(
        Rank startingRank,
        List<Card> cards
        )
    {
        Rank highRank = Ranks.Empty;
        List<Card> sequence = new();

        List<Card> unusedCards = new();
        unusedCards.AddRange(cards);

        for (uint r = 0; r < GlobalConstants.HandSize; r++)
        {
            // for some reason the compiler doesn't like this when used
            // in an inline expression. 🤷
            uint nextRankValue = startingRank.Value + r;

            var rank = Ranks.All
                .Where(r => r.Value.Equals(nextRankValue))
                .FirstOrDefault();

            if (rank is null)
                break;

            var cardInSeqeuence = unusedCards
                .Where(c => c.MatchesRankOrIsWild(rank))
                .OrderBy(c => c.IsWild) // prefer non-wild
                .OrderBySuit()
                .FirstOrDefault() ?? Cards.Empty;

            if (cardInSeqeuence == Cards.Empty)
                return new PotentialHandMessage
                {
                    Suit = Suits.Empty,
                    HighRank = highRank,
                    Complete = false,
                    Cards = sequence
                };

            if (cardInSeqeuence.IsWild)
                cardInSeqeuence = cardInSeqeuence with
                {
                    Impersonating = Cards
                        .All
                        .WhereRank(rank)
                        .OrderBy(cards.Contains)
                        .OrderBySuit()
                        .First()
                };

            highRank = rank;
            sequence.Add(cardInSeqeuence);
            unusedCards.Remove(cardInSeqeuence);
        }

        return new PotentialHandMessage
        {
            Suit = Suits.Empty,
            HighRank = highRank,
            Complete = true,
            Cards = sequence
        };
    }
}
