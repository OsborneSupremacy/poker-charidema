namespace Poker.Domain.Implementations;

public static partial class HandQualifierDelegates
{
    public static HandQualifier TwoPairHandQualifier { get; } =
        (QualifiedHandRequest request) =>
    {
        var firstPair =
            GetPotentialMatchingRankHand(request.Cards, 2, request.RemainingCardCount);

        if (!firstPair.Complete)
            return request.Cards.ToUnqualifiedHand(
                Hands.TwoPair,
                request.RemainingCardCount >= 2
            );

        var secondPair = 
            GetPotentialMatchingRankHand(firstPair.NonContributing, 2, request.RemainingCardCount);

        if (!secondPair.Complete)
            return request.Cards.ToUnqualifiedHand(
                Hands.FullHouse,
                request.RemainingCardCount > 0
            );

        return request.Hand.ToQualifiedHand(
            firstPair.CombineWith(secondPair)
        );
    };
}
