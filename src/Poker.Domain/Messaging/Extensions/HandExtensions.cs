namespace Poker.Domain.Messaging.Extensions;

public static class HandExtensions
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
