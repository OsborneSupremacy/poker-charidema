namespace Poker.Domain.Implementations.HandQualifiers;

public static partial class HandQualifierDelegates
{
    public static HandQualifier FullHouseHandQualifier { get; } =
        (QualifiedHandRequest request) =>
    {
        var threeOfAKind = 
            MatchingRankHandQualifier!(request with { Hand = Hands.ThreeOfAKind });

        return threeOfAKind.HandQualification switch
        {
            HandQualifications.Eliminated => request.Cards.ToUnqualifiedHand(request.Hand, false),
            HandQualifications.Possible => QualifyWithoutThreeOfAKind(request),
            _ => QualifyWithTheeOfAKind(request.Cards, threeOfAKind, request.RemainingCardCount)
        };
    };

    private static QualifiedHandResponse QualifyWithoutThreeOfAKind(QualifiedHandRequest request)
    {
        if (request.RemainingCardCount >= 4)
            return request.Cards.ToUnqualifiedHand(Hands.FullHouse, true);

        var hasPair = MatchingRankHandQualifier(new QualifiedHandRequest
        {
            Hand = request.Hand,
            Cards = request.Cards,
            RemainingCardCount = request.RemainingCardCount
        }).HandQualification == HandQualifications.Qualifies;

        var requiredAdditionalCards = hasPair ? 3 : 2;

        return request.Cards.ToUnqualifiedHand(Hands.FullHouse, request.RemainingCardCount >= requiredAdditionalCards);
    }

    private static QualifiedHandResponse QualifyWithTheeOfAKind(
        List<Card> cards,
        QualifiedHandResponse threeOfAKind,
        uint remainingCardCount
        )
    {
        var additionalPair = MatchingRankHandQualifier(new QualifiedHandRequest
        {
            Hand = Hands.Pair,
            Cards = cards.Except(threeOfAKind.HandCards).ToList(),
            RemainingCardCount = remainingCardCount
        });

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


