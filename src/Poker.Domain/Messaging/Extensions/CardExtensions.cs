namespace Poker.Domain.Messaging.Extensions;

public static class CardExtensions
{
    public static QualifiedHandResponse ToQualifiedHand(
        this Hand hand,
        List<Card> contributingStandardCards,
        List<AssignedWildCard> contributingWildCards,
        List<Card> nonContributingCards
        )
    {
        var kickerCount = GlobalConstants.HandSize - contributingStandardCards.Count;

        return new QualifiedHandResponse
        {
            Hand = hand,
            ContributingStandardCards = contributingStandardCards,
            ContributingWildCards = contributingWildCards,
            Kickers = nonContributingCards
                .OrderByPokerStandard()
                .Take(kickerCount)
                .ToList(),
            DeadCards = nonContributingCards
                .OrderByPokerStandard()
                .Skip(kickerCount)
                .ToList(),
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
