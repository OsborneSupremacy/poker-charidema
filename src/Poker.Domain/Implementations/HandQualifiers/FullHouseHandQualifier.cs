namespace Poker.Domain.Implementations;

public static partial class HandQualifierDelegates
{
    public static HandQualifier FullHouseHandQualifier { get; } =
        (QualifiedHandRequest request) =>
    {
        var threeOfAKind = GetPotentialMatchingRankHand(
            request with { Hand = Hands.ThreeOfAKind }
        );

        var additionalPair =
            GetPotentialMatchingRankHand(
                request with
                {
                    Cards = threeOfAKind.NonContributing,
                    Hand = Hands.Pair,
                    RemainingCardCount =
                        request.RemainingCardCount
                        - threeOfAKind.NeededCardMessage.Cards.Count.ToUint()
                }
            );
 
        return (threeOfAKind.Complete, additionalPair.Complete) switch
        {
            (true, true) =>
                request.Hand
                    .ToQualifiedHand(threeOfAKind.CombineWith(additionalPair)),

            (true, false) =>
                request.Cards
                    .ToUnqualifiedHand(request.Hand, additionalPair.EnoughRemainingCards()),

            (false, true) =>
                request.Cards
                .ToUnqualifiedHand(request.Hand, threeOfAKind.EnoughRemainingCards()),

            (false, false) =>
                request.Cards
                    .ToUnqualifiedHand(request.Hand, threeOfAKind.EnoughRemainingCards() && additionalPair.EnoughRemainingCards())
        };
    };

}


