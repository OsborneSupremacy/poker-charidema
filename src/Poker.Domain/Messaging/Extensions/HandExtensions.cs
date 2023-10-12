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
            - (potentialHand.ContributingStandard.Count + potentialHand.ContributingWild.Count);

        return new QualifiedHandResponse
        {
            HighRank = potentialHand.HighRank,
            Suit = potentialHand.Suit,
            Hand = hand,
            ContributingStandardCards = potentialHand.ContributingStandard,
            ContributingWildCards = potentialHand.ContributingWild,
            Kickers = potentialHand.NonContributing
                .OrderByPokerStandard()
                .Take(kickerCount)
                .ToList(),
            DeadCards = potentialHand.NonContributing
                .OrderByPokerStandard()
                .Skip(kickerCount)
                .ToList(),
            HandQualification = HandQualifications.Qualifies,
            NeededCardGroups = new()
        };
    }

    public static QualifiedHandResponse ToUnqualifiedHand(
        this Hand hand,
        PotentialHandMessage potentialHand,
        bool possible
        ) =>
            new()
            {
                HighRank = Ranks.Empty,
                Suit = Suits.Empty,
                Hand = hand,
                ContributingStandardCards = new(),
                ContributingWildCards = new(),
                DeadCards = potentialHand
                    .ContributingStandard
                    .Union(potentialHand.ContributingWild.Select(w => w.WildCard))
                    .Union(potentialHand.NonContributing)
                    .OrderByPokerStandard()
                    .ToList(),
                Kickers = new(),
                HandQualification =
                    possible
                    ? HandQualifications.Possible
                    : HandQualifications.Eliminated,
                NeededCardGroups = potentialHand.NeededCardMessage.Groups
            };
}
