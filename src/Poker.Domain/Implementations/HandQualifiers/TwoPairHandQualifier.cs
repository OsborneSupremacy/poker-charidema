namespace Poker.Domain.Implementations;

public static partial class HandQualifierDelegates
{
    public static HandQualifier TwoPairHandQualifier { get; } =
        (QualifiedHandRequest request) =>
    {
        var firstPair =
            GetPotentialMatchingRankHand(request.Cards, 2);

        if (!firstPair.Complete)
            return request.Cards.ToUnqualifiedHand(
                Hands.TwoPair,
                request.RemainingCardCount >= 2
            );

        var secondPair = 
            GetPotentialMatchingRankHand(firstPair.NonContributing, 2);

        if (!secondPair.Complete)
            return request.Cards.ToUnqualifiedHand(
                Hands.FullHouse,
                request.RemainingCardCount > 0
            );

        return request.Hand.ToQualifiedHand(
            firstPair
                .ContributingStandardCards
                .Concat(secondPair.ContributingStandardCards)
                .ToList(),
            firstPair
                .ContributingWildCards
                .Concat(secondPair.ContributingWildCards)
                .ToList(),
            secondPair.NonContributing
        );
    };
}
