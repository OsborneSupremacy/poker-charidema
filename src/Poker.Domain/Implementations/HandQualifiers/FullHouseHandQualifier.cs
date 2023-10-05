namespace Poker.Domain.Implementations;

public static partial class HandQualifierDelegates
{
    public static HandQualifier FullHouseHandQualifier { get; } =
        (QualifiedHandRequest request) =>
    {
        var threeOfAKind = GetPotentialMatchingRankHand(request.Cards, 3, request.RemainingCardCount);

        if(!threeOfAKind.Complete)
            return request.Cards.ToUnqualifiedHand(
                Hands.FullHouse,
                request.RemainingCardCount >= RequiredAdditionalCards(request.Cards, request.RemainingCardCount)
            );

        var additionalPair = 
            GetPotentialMatchingRankHand(threeOfAKind.NonContributing, 2, request.RemainingCardCount);

        if (!additionalPair.Complete)
            return request.Cards.ToUnqualifiedHand(
                Hands.FullHouse,
                request.RemainingCardCount > 0
            );

        return request.Hand.ToQualifiedHand(
            threeOfAKind.CombineWith(additionalPair)
        );
    };

    private static int RequiredAdditionalCards(List<Card> cards, uint remainingCardCount) =>
        HasPair(cards, remainingCardCount) ? 3 : 2;

    private static bool HasPair(List<Card> cards, uint remainingCardCount) =>
        GetPotentialMatchingRankHand(cards, 2, remainingCardCount).Complete;
}


