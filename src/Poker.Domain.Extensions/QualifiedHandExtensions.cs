using Poker.Domain.Classic;

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

    public static Rank GetHighRank(this QualifiedHand input)
    {
        var regRank = input.HandCards
            .Where(c => !c.IsWild)
            .Max(c => c.Rank.Value);

        var wildRank = input.HandCards
            .Where(c => c.IsWild)
            .Where(c => c.Impersonating != Cards.Empty)
            .Max(c => c.Impersonating.Rank.Value);

        var maxRank = regRank > wildRank ? regRank : wildRank;

        return Ranks.All
            .Where(r => r.Value == maxRank)
            .SingleOrDefault() ?? Ranks.Empty;
    }
}
