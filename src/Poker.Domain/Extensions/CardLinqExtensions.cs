namespace Poker.Domain.Extensions;

internal static class CardLinqExtensions
{
    public static IEnumerable<Card> WhereSuit(
        this IEnumerable<Card> cards, Suit suit
        ) => cards.Where(x => x.MatchesSuit(suit));

    public static IEnumerable<Card> WhereRank(
        this IEnumerable<Card> cards, Rank rank
        ) => cards.Where(x => x.MatchesRank(rank));

    public static IEnumerable<Card> WhereRanksOrIsWild(
        this IEnumerable<Card> cards, Rank rank
        ) => cards.Where(x => x.MatchesRankOrIsWild(rank));

    public static IEnumerable<Card> WhereWild(this IEnumerable<Card> cards) =>
        cards.Where(x => x.IsWild);

    public static IOrderedEnumerable<Card> OrderByPokerStandard(this IEnumerable<Card> cards) =>
        cards
            .OrderByRank()
            .OrderBySuit();

    public static IOrderedEnumerable<Card> OrderBySuit(this IEnumerable<Card> cards) =>
        cards
            .OrderByDescending(
                c => c.Suit.Priority
            );

    public static IOrderedEnumerable<Card> OrderByRank(this IEnumerable<Card> cards) =>
        cards
            .OrderByDescending(
                c => c.Rank.Value
            );
}
