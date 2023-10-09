namespace Poker.Domain.Implementations;

public static partial class HandQualifierDelegates
{
    public static HandQualifier StraightFlushHandQualifier { get; } =
        (QualifiedHandRequest request) =>
        {
            var potential = FindPotentialStraightFlushes(request);
            var complete = potential.WhereComplete();

            if (complete.Any())
                return request.Hand
                    .ToQualifiedHand(
                        GetBestStraightFlush(complete)
                    );

            var best = GetBestStraightFlush(
                potential
                    .WithFewestNeededCards()
            );

            return request.Hand.ToUnqualifiedHand(
                best,
                best.EnoughRemainingCards()
            );
        };

    private static PotentialHandMessage GetBestStraightFlush(
        IEnumerable<PotentialHandMessage> potential
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
    private static IEnumerable<PotentialHandMessage> FindPotentialStraightFlushes(QualifiedHandRequest request) =>
        EvaluateStraights(request)
            .Join(
                EvaluateFlushes(request),
                    straight => straight.AggregateValue(),
                    flush => flush.AggregateValue(),
                    (straight, flush) => straight.MergeWith(flush)
            );
}


