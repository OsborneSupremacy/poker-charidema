namespace Poker.Domain.Messaging.Extensions;

internal static class HandExtensions
{
    public static QualifiedHandResponse ToQualifiedHand(
        this Hand hand,
        PotentialHandMessage potentialHand
        )
    {
        var kickerCount =
            GlobalConstants.HandSize
            - (potentialHand.ContributingStandardCards.Count + potentialHand.ContributingWildCards.Count);

        return new QualifiedHandResponse
        {
            HighRank = potentialHand.HighRank,
            Suit = potentialHand.Suit,
            Hand = hand,
            ContributingStandardCards = potentialHand.ContributingStandardCards,
            ContributingWildCards = potentialHand.ContributingWildCards,
            Kickers = potentialHand.NonContributing
                .OrderByPokerStandard()
                .Take(kickerCount)
                .ToList(),
            DeadCards = potentialHand.NonContributing
                .OrderByPokerStandard()
                .Skip(kickerCount)
                .ToList(),
            HandQualification = HandQualifications.Qualifies
        };
    }
}
