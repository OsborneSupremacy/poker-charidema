using System.Numerics;

namespace Poker.Domain.Implementations;

public static partial class HandQualifierDelegates
{
    public static HandQualifier StraightFlushHandQualifier { get; } =
        (QualifiedHandRequest request) =>
        {
            var potentials = FindPotentialStraightFlushes(request).ToList();
            var complete = potentials.Where(x => x.Complete).ToList();

            if (!complete.Any())
                return request.Cards.ToUnqualifiedHand(
                    request.Hand,
                    potentials.AnyWithEnoughRemainingCards()
                );

            return request.Hand.ToQualifiedHand(GetBestStraightFlush(complete));
        };

    private static PotentialHandMessage GetBestStraightFlush(
        List<PotentialHandMessage> potential
    ) =>
        potential
            .Where(x => x.HighRank.Value == potential.Max(x => x.HighRank.Value))
            .OrderByDescending(x => x.Suit.Priority)
            .First();

    /// <summary>
    /// Returns the intersection of <see cref="EvaluateFlushes(List{Card})"/> and <see cref="EvalulatedStraight"/>, 
    /// joining on this list of cards that those methods return. Since the list of cards returned by those methods
    /// are only the cards that count towards satisfying their respective hands, this method is not 
    /// guaranteeed to return any records.
    /// </summary>
    /// <param name="cards"></param>
    /// <returns></returns>
    private static IEnumerable<PotentialHandMessage> FindPotentialStraightFlushes(QualifiedHandRequest request)
    {
        var straights = EvaluateStraights(request);

        foreach (var flush in EvaluateFlushes(request))
            foreach (
                var straight in straights
                    .Where(
                        x => x.AggregateValue() == flush.AggregateValue()
                    )
                )
                yield return (flush.Complete, straight.Complete) switch
                {
                    (true, true) => new PotentialHandMessage
                    {
                        HighRank = flush.HighRank,
                        Suit = flush.Suit,
                        ContributingStandardCards = flush.ContributingStandardCards,
                        ContributingWildCards = flush.ContributingWildCards,
                        NonContributing = flush.NonContributing,
                        Complete = true,
                        RemainingCardCount = request.RemainingCardCount,
                        NeededCardMessage = NeededCardMessageBuilder.Empty()
                    },

                    (true, false) => new PotentialHandMessage
                    {
                        HighRank = flush.HighRank,
                        Suit = flush.Suit,
                        ContributingStandardCards = flush.ContributingStandardCards,
                        ContributingWildCards = flush.ContributingWildCards,
                        NonContributing = flush.NonContributing,
                        Complete = false,
                        RemainingCardCount = request.RemainingCardCount,
                        NeededCardMessage = straight.NeededCardMessage
                    },

                    (false, true) => new PotentialHandMessage
                    {
                        HighRank = straight.HighRank,
                        Suit = flush.Suit,
                        ContributingStandardCards = straight.ContributingStandardCards,
                        ContributingWildCards = straight.ContributingWildCards,
                        NonContributing = straight.NonContributing,
                        Complete = false,
                        RemainingCardCount = request.RemainingCardCount,
                        NeededCardMessage = flush.NeededCardMessage
                    },

                    (false, false) => new PotentialHandMessage
                    {
                        HighRank = flush.HighRank,
                        Suit = flush.Suit,
                        ContributingStandardCards = flush.ContributingStandardCards,
                        ContributingWildCards = flush.ContributingWildCards,
                        NonContributing = flush.NonContributing,
                        Complete = false,
                        RemainingCardCount = request.RemainingCardCount,
                        NeededCardMessage = straight
                            .CombineWith(flush)
                            .NeededCardMessage
                    }
                };
    }
}


