namespace Poker.Domain.Extensions;

public static class QualifiedHandExtensions
{
    public static bool Eliminated(this QualifiedHand input) =>
        input.HandQualification == HandQualifications.Eliminated;

    public static bool DoesNotCurrentlyQualify(this QualifiedHand input) =>
        new[] { HandQualifications.Eliminated, HandQualifications.Possible }
            .Contains(input.HandQualification);

    public static bool Qualifies(this QualifiedHand input) =>
        input.HandQualification == HandQualifications.Qualifies;
}
