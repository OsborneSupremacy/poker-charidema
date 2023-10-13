namespace Poker.Domain.Implementations;

public static partial class HandQualifierDelegates
{
    public static HandQualifier TwoPairHandQualifier { get; } =
        (QualifiedHandRequest request) =>
    {
        var firstPair =
            GetPotentialMatchingRankHand(
                request with { Hand = HandDefinitions.Pair }
            );

        var secondPair =
            GetPotentialMatchingRankHand(
                request with
                {
                    Cards = firstPair.NonContributing,
                    Hand = HandDefinitions.Pair,
                    RemainingCardCount =
                        request.RemainingCardCount
                        - firstPair.NeeededCardCount()
                }
            );

        var combinedHand = firstPair.MergeWith(secondPair);

        if(combinedHand.Complete)
            return request.Hand
                .ToQualifiedHand(combinedHand);

        // if first pair is complete. needed cards should be from second hand only
        if (firstPair.Complete && !secondPair.Complete)
            combinedHand = combinedHand with
            {
                NeededCardMessage = secondPair.NeededCardMessage
            };

        return request.Hand
            .ToUnqualifiedHand(combinedHand, combinedHand.EnoughRemainingCards());
    };

}
