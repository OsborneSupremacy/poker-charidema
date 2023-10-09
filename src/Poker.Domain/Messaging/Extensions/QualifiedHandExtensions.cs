namespace Poker.Domain.Messaging.Extensions;

public static class QualifiedHandExtensions
{
    public static bool Eliminated(this QualifiedHandResponse input) =>
        input.HandQualification == HandQualifications.Eliminated;

    public static bool DoesNotCurrentlyQualify(this QualifiedHandResponse input) =>
        new[] { HandQualifications.Eliminated, HandQualifications.Possible }
            .Contains(input.HandQualification);

    public static bool Qualifies(this QualifiedHandResponse input) =>
        input.HandQualification == HandQualifications.Qualifies;

    public static PotentialHandMessage MergeWith(
        this PotentialHandMessage input,
        PotentialHandMessage other
        ) =>
        input with
        {
            HighRank = input.HighRank == Ranks.Empty ? other.HighRank : input.HighRank,
            Suit = input.Suit == Suits.Empty ? other.Suit : input.Suit,

            Complete = input.Complete && other.Complete,

            ContributingStandard = input
                .ContributingStandard
                .Concat(other.ContributingStandard)
                .ToList(),

            ContributingWild = input
                .ContributingWild
                .Concat(other.ContributingWild)
                .ToList(),

            NonContributing = input
                .NonContributing
                .Except(other.ContributingStandard)
                .ToList(),

            NeededCardMessage = input.NeededCardMessage with
            {
                Cards = input
                    .NeededCardMessage
                    .Cards
                    .Union(other.NeededCardMessage.Cards)
                    .ToList()
            }
        };
}
