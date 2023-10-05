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

    public static Rank GetHighRank(this QualifiedHandResponse input) =>
        input.ContributingStandardCards
            .GetMaxRank(input.ContributingWildCards);

    public static PotentialHandMessage CombineWith(this PotentialHandMessage input, PotentialHandMessage other) =>
        input with
        {
            ContributingStandardCards = 
                input.ContributingStandardCards.Concat(other.ContributingStandardCards).ToList(),
            ContributingWildCards =
                input.ContributingWildCards.Concat(other.ContributingWildCards).ToList(),
            NonContributing = other.NonContributing.ToList()
        };
}
