namespace Poker.Domain.Implementations;

public static partial class HandQualifierDelegates
{
    public static HandQualifier TwoPairHandQualifier { get; } =
        (QualifiedHandRequest request) =>
    {
        var firstPair =
            GetPotentialMatchingRankHand(
                request with { Hand = Hands.Pair }
            );

        var secondPair =
            GetPotentialMatchingRankHand(
                request with
                {
                    Cards = firstPair.NonContributing,
                    Hand = Hands.Pair,
                    RemainingCardCount =
                        request.RemainingCardCount
                        - firstPair.NeeededCardCount()
                }
            );

        var combinedHand = firstPair.MergeWith(secondPair);

        return combinedHand.Complete switch
        {
            true =>
                request.Hand
                    .ToQualifiedHand(combinedHand),

            false =>
                request.Hand
                    .ToUnqualifiedHand(combinedHand, combinedHand.EnoughRemainingCards())
        };
    };
}
