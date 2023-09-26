namespace Poker.Domain.Extensions;

public static class RankLinqExtensions
{
    public static IOrderedEnumerable<Rank> OrderByPokerStandard(this IEnumerable<Rank> ranks) =>
        ranks.OrderByDescending(x => x.Value);
}
