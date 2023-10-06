namespace Poker.Domain.Extensions;

internal static class SuitLinqExtensions
{
    public static IOrderedEnumerable<Suit> OrderByPokerStandard(this IEnumerable<Suit> suits) =>
        suits.OrderByDescending(x => x.Priority);
}
