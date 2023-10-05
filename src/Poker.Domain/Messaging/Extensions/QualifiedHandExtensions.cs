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
}
