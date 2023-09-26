namespace Poker.Domain.Extensions;

public static class SuitLinqExtensions
{
    public static IOrderedEnumerable<Suit> OrderByPokerStandard(this IEnumerable<Suit> suits) =>
        suits.OrderByDescending(x => x.Priority);
}
