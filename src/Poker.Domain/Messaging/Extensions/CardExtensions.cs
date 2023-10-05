namespace Poker.Domain.Messaging.Extensions;

public static class CardExtensions
{
    public static QualifiedHandResponse ToUnqualifiedHand(
        this List<Card> cards,
        Hand hand,
        bool possible
        ) =>
            new()
            {
                Hand = hand,
                ContributingStandardCards = new(),
                ContributingWildCards = new(),
                DeadCards = cards,
                Kickers = new(),
                HandQualification =
                    possible
                    ? HandQualifications.Possible
                    : HandQualifications.Eliminated
            };
}
