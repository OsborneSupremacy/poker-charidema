namespace Poker.Domain.Implementations.HandQualifiers;

public static partial class HandQualifierDelegates
{
    public static HandQualifier FullHouseHandQualifier { get; } =
        (Hand hand, List<Card> cards, uint remainingCardCount) =>
    {
        var threeOfAKind = 
            MatchingRankHandQualifier(Hands.ThreeOfAKind, cards, remainingCardCount);

        return threeOfAKind.HandQualification switch
        {
            HandQualifications.Eliminated => cards.ToUnqualifiedHand(hand, false),
            HandQualifications.Possible => QualifyFullHouse(cards, remainingCardCount),
            _ => QualifyFullHouse(cards, threeOfAKind, remainingCardCount)
        };
    };

    private static QualifiedHand QualifyFullHouse(
        List<Card> cards,
        uint remainingCardCount
        )
    {
        if (remainingCardCount >= 4)
            return cards.ToUnqualifiedHand(Hands.FullHouse, true);

        var hasPair = MatchingRankHandQualifier(Hands.Pair, cards, remainingCardCount)
            .HandQualification == HandQualifications.Qualifies;

        var requiredAdditionalCards = hasPair ? 3 : 2;

        return cards.ToUnqualifiedHand(Hands.FullHouse, remainingCardCount >= requiredAdditionalCards);
    }

    private static QualifiedHand QualifyFullHouse(
        List<Card> cards,
        QualifiedHand threeOfAKind,
        uint remainingCardCount
        )
    {
        var additionalPair = MatchingRankHandQualifier(
            Hands.Pair,
            cards.Except(threeOfAKind.HandCards).ToList(),
            remainingCardCount
        );

        return additionalPair.Qualifies() switch
        {
            true => cards.ToQualifiedHand(
                Hands.FullHouse,
                threeOfAKind.HandCards.Concat(additionalPair.HandCards).ToList()
            ),
            false => cards.ToUnqualifiedHand(
                Hands.FullHouse,
                !additionalPair.Eliminated() // if an additional pair is possible, full house is possible
            )
        };
    }
}


