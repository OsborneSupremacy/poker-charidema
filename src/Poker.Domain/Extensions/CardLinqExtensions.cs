namespace Poker.Domain.Extensions;

internal static class CardLinqExtensions
{
    public static IEnumerable<Card> Rank(
        this IEnumerable<Card> cards, Rank rank
        ) => cards.Where(x => x.MatchesRank(rank));

    public static IEnumerable<Card> Standard(this IEnumerable<Card> cards) =>
        cards.Where(x => !x.IsWild);

    public static IEnumerable<Card> Wild(this IEnumerable<Card> cards) =>
        cards.Where(x => x.IsWild);

    public static IOrderedEnumerable<Card> OrderByPokerStandard(this IEnumerable<Card> cards) =>
        cards
            .OrderByDescending(c => c.Rank.Value)
            .ThenByDescending(c => c.Suit.Priority);
}
