namespace Poker.Domain.Implementations.HandQualifiers;

public static partial class HandQualifierDelegates
{
    public static HandQualifier FullHouseHandQualifier { get; } =
        (Hand hand, List<Card> cards, uint remainingCardCount) =>
    {
        var threeOfAKind = 
            MatchingRankHandQualifier(Hands.ThreeOfAKind, cards, remainingCardCount);

        switch (threeOfAKind.HandQualification) {

            case HandQualifications.Eliminated:
                return cards.ToUnqualifiedHand(hand, false);

            case HandQualifications.Possible:

                if (remainingCardCount >= 4)
                    return cards.ToUnqualifiedHand(hand, true);

                var hasPair = MatchingRankHandQualifier(Hands.Pair, cards, remainingCardCount)
                    .HandQualification == HandQualifications.Qualifies;

                var requiredAdditionalCards = hasPair ? 3 : 2;

                return cards.ToUnqualifiedHand(hand, remainingCardCount >= requiredAdditionalCards);
        }

        var additionalPair = MatchingRankHandQualifier(
            Hands.Pair,
            cards.Except(threeOfAKind.HandCards).ToList(),
            remainingCardCount
        );

        return additionalPair.Qualifies() switch
        {
            true => cards.ToQualifiedHand(
                hand,
                threeOfAKind.HandCards.Concat(additionalPair.HandCards).ToList()),
            false => cards.ToUnqualifiedHand(
                hand,
                !additionalPair.Eliminated() // if a additiona pair is possible, full house is possible
            )
        };
    };
}


