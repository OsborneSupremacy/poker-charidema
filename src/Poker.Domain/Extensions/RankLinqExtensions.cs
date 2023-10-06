namespace Poker.Domain.Extensions;

internal static class RankLinqExtensions
{
    public static IOrderedEnumerable<Rank> OrderByPokerStandard(this IEnumerable<Rank> ranks) =>
        ranks.OrderByDescending(x => x.Value);
}
