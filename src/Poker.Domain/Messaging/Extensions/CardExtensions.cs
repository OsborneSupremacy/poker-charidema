namespace Poker.Domain.Messaging.Extensions;

public static class CardExtensions
{
    public static QualifiedHandResponse ToQualifiedHand(
        this List<Card> cards,
        Hand hand,
        List<Card> handCards)
    {
        var kickers = cards.GetKickers(handCards);

        return new QualifiedHandResponse
        {
            Hand = hand,
            HandCards = handCards,
            Kickers = kickers,
            DeadCards = cards.GetDeadCards(handCards, kickers),
            HandQualification = HandQualifications.Qualifies
        };
    }

    public static QualifiedHandResponse ToUnqualifiedHand(
        this List<Card> cards,
        Hand hand,
        bool possible
        ) =>
            new()
            {
                Hand = hand,
                HandCards = new(),
                DeadCards = cards,
                Kickers = new(),
                HandQualification =
                    possible
                    ? HandQualifications.Possible
                    : HandQualifications.Eliminated
            };
}
