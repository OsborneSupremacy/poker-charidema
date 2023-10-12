namespace Poker.Domain.Extensions;

internal static class SuitLinqExtensions
{
    public static string AggregateValue(this IEnumerable<Suit> suits) =>
        string.Join('|', suits.Select(x => x.Priority).OrderBy(x => x));

    public static IOrderedEnumerable<Suit> OrderByPokerStandard(this IEnumerable<Suit> suits) =>
        suits.OrderByDescending(x => x.Priority);
}
