namespace Poker.Domain.Extensions;

internal static class CardLinqExtensions
{
    public static IEnumerable<Card> WhereSuit(
        this IEnumerable<Card> cards, Suit suit
        ) => cards.Where(x => x.MatchesSuit(suit));

    public static IEnumerable<Card> WhereRank(
        this IEnumerable<Card> cards, Rank rank
        ) => cards.Where(x => x.MatchesRank(rank));

    public static IEnumerable<Card> WhereStandard(this IEnumerable<Card> cards) =>
        cards.Where(x => !x.IsWild);

    public static IEnumerable<Card> WhereWild(this IEnumerable<Card> cards) =>
        cards.Where(x => x.IsWild);

    public static IOrderedEnumerable<Card> OrderByPokerStandard(this IEnumerable<Card> cards) =>
        cards
            .OrderByDescending(c => c.Rank.Value)
            .ThenByDescending(c => c.Suit.Priority);
}

