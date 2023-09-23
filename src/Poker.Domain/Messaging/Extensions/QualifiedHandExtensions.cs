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

    public static Rank GetHighRank(this QualifiedHandResponse input)
    {
        var regRank = input.HandCards
            .Where(c => !c.IsWild)
            .GetMaxRank().Value;

        var wildRank = input.HandCards
            .Where(c => c.IsWild)
            .Where(c => c.Impersonating != Cards.Empty)
            .GetMaxRank().Value;

        var maxRank = regRank > wildRank ? regRank : wildRank;

        return Ranks.All
            .Where(r => r.Value == maxRank)
            .SingleOrDefault() ?? Ranks.Empty;
    }
}
