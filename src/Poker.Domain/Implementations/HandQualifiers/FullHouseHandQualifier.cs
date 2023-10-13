namespace Poker.Domain.Implementations;

public static partial class HandQualifierDelegates
{
    public static HandQualifier FullHouseHandQualifier { get; } =
        (QualifiedHandRequest request) =>
    {
        var threeOfAKind = GetPotentialMatchingRankHand(
            request with { Hand = HandDefinitions.ThreeOfAKind }
        );

        var additionalPair =
            GetPotentialMatchingRankHand(
                request with
                {
                    Cards = threeOfAKind.NonContributing,
                    Hand = HandDefinitions.Pair,
                    RemainingCardCount =
                        request.RemainingCardCount
                        - threeOfAKind.NeededCardMessage.Groups.Count.ToUint()
                }
            );

        var combinedHand = threeOfAKind.MergeWith(additionalPair);
 
        return (combinedHand.Complete) switch
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


