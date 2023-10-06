namespace Poker.Domain.Messaging.Extensions;

internal static class CardExtensions
{
    public static QualifiedHandResponse ToUnqualifiedHand(
        this List<Card> cards,
        Hand hand,
        bool possible
        ) =>
            new()
            {
                HighRank = Ranks.Empty,
                Suit = Suits.Empty,
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
