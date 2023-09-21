namespace Poker.Domain.Implementations.HandQualifiers;

public static partial class HandQualifierDelegates
{
    public static HandQualifier TwoPairHandQualifier { get; } =
        (QualifiedHandRequest request) =>
    {
        var firstPair = 
            MatchingRankHandQualifier!(request with { Hand = Hands.Pair });

        return firstPair.HandQualification switch
        {
            HandQualifications.Eliminated => request.Cards.ToUnqualifiedHand(request.Hand, false),
            HandQualifications.Possible => request.Cards.ToUnqualifiedHand(
                Hands.TwoPair,
                request.RemainingCardCount >= 2
            ),
            _ => QualifyWithFirstPair(request.Cards, firstPair, request.RemainingCardCount)
        };
    };

    private static QualifiedHandResponse QualifyWithFirstPair(
        List<Card> cards,
        QualifiedHandResponse firstPair,
        uint remainingCardCount
    )
    {
        var secondPair = MatchingRankHandQualifier(
            new QualifiedHandRequest
            {
                Hand = Hands.Pair,
                Cards = cards.Except(firstPair.HandCards).ToList(),
                RemainingCardCount = remainingCardCount
            }
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
