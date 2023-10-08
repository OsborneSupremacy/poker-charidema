namespace Poker.Domain.Extensions;

internal static class RankLinqExtensions
{
    public static IOrderedEnumerable<Rank> OrderByPokerStandard(this IEnumerable<Rank> ranks) =>
        ranks.OrderByDescending(x => x.Value);

    public static Rank High(this IEnumerable<Rank>? ranks)
    {
        if(!ranks?.Any() ?? false)
            return Ranks.Empty;

        return Ranks.All
            .SingleOrDefault(x => x.Value == ranks!.Max(x => x.Value)) ?? Ranks.Empty;
    }
}
