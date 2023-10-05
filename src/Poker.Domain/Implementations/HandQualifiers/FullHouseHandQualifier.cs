namespace Poker.Domain.Implementations;

public static partial class HandQualifierDelegates
{
    public static HandQualifier FullHouseHandQualifier { get; } =
        (QualifiedHandRequest request) =>
    {
        var threeOfAKind = GetPotentialMatchingRankHand(request.Cards, 3);

        if(!threeOfAKind.Complete)
            return request.Cards.ToUnqualifiedHand(
                Hands.FullHouse,
                request.RemainingCardCount >= RequiredAdditionalCards(request.Cards)
            );

        var additionalPair = 
            GetPotentialMatchingRankHand(threeOfAKind.NonContributing, 2);

        if (!additionalPair.Complete)
            return request.Cards.ToUnqualifiedHand(
                Hands.FullHouse,
                request.RemainingCardCount > 0
            );

        return request.Hand.ToQualifiedHand(
            threeOfAKind
                .ContributingStandardCards
                .Concat(additionalPair.ContributingStandardCards)
                .ToList(),
            threeOfAKind
                .ContributingWildCards
                .Concat(additionalPair.ContributingWildCards)
                .ToList(),
            additionalPair.NonContributing
        );
    };

    private static int RequiredAdditionalCards(List<Card> cards) =>
        HasPair(cards) ? 3 : 2;

    private static bool HasPair(List<Card> cards) =>
        GetPotentialMatchingRankHand(cards, 2).Complete;
}


