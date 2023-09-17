namespace Poker.Domain.Implementations.HandQualifiers;

public static partial class HandQualifierDelegates
{
    public static HandQualifier TwoPairHandQualifier { get; } =
        (Hand hand, List<Card> cards, uint remainingCardCount) =>
    {
        var firstPair = 
            MatchingRankHandQualifier(Hands.Pair, cards, remainingCardCount);

        return firstPair.HandQualification switch
        {
            HandQualifications.Eliminated => cards.ToUnqualifiedHand(hand, false),
            HandQualifications.Possible => cards.ToUnqualifiedHand(
                Hands.TwoPair,
                remainingCardCount >= 2
            ),
            _ => QualifyWithFirstPair(cards, firstPair, remainingCardCount)
        };
    };

    private static QualifiedHand QualifyWithFirstPair(
        List<Card> cards,
        QualifiedHand firstPair,
        uint remainingCardCount
    )
    {
        var secondPair = MatchingRankHandQualifier(
            Hands.Pair,
            cards.Except(firstPair.HandCards).ToList(),
            remainingCardCount
        );

        return secondPair.Qualifies() switch
        {
            true => cards.ToQualifiedHand(
                Hands.TwoPair,
                firstPair.HandCards.Concat(secondPair.HandCards).ToList()
            ),
            false => cards.ToUnqualifiedHand(
                Hands.TwoPair,
                !secondPair.Eliminated() // If a second pair is possible, two pair is possible
            )
        };
    }
}
