namespace Poker.Domain.Extensions;

internal static class RankLinqExtensions
{
    public static IOrderedEnumerable<Rank> OrderByPokerStandard(this IEnumerable<Rank> ranks) =>
        ranks.OrderByDescending(x => x.Value);

    public static string AggregateValue(this IEnumerable<Rank> ranks) =>
        string.Join('|', ranks.Select(x => x.Value).OrderBy(x => x));

    public static Rank High(this IEnumerable<Rank>? ranks)
    {
        var rankList = ranks?.ToList() ?? new List<Rank>();
        
        if(!rankList.Any())
            return Ranks.Empty;

        return Ranks.All
            .SingleOrDefault(x => x.Value == rankList.Max(r => r.Value)) ?? Ranks.Empty;
    }
}
