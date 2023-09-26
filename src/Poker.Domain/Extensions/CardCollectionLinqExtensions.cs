namespace Poker.Domain.Extensions;

public static class CardCollectionLinqExtensions
{
    public static IEnumerable<Card> WhereSuit(
        this IEnumerable<Card> cards, Suit suit
        ) => cards.Where(x => x.MatchesSuit(suit));

    public static IEnumerable<Card> WhereRank(
        this IEnumerable<Card> cards, Rank rank
        ) => cards.Where(x => x.MatchesRank(rank));

    public static IEnumerable<Card> WhereSuitOrIsWild(
        this IEnumerable<Card> cards, Suit suit
        ) => cards.Where(x => x.MatchesSuitOrIsWild(suit));

    public static IEnumerable<Card> WhereRanksOrIsWild(
        this IEnumerable<Card> cards, Rank rank
        ) => cards.Where(x => x.MatchesRankOrIsWild(rank));

    public static IEnumerable<Card> WhereWild(this IEnumerable<Card> cards) =>
        cards.Where(x => x.IsWild);

    public static IEnumerable<Card> WhereNotWild(this IEnumerable<Card> cards) =>
        cards.Where(x => x.IsWild);

    public static IOrderedEnumerable<Card> OrderByPokerStandard(this IEnumerable<Card> cards) =>
        cards
            .OrderByDescending(c => c.IsWild)
            .ThenByDescending(c => c.Rank.Value)
            .ThenByDescending(c => c.Suit.Priority);

    public static IOrderedEnumerable<Card> OrderBySuit(this IEnumerable<Card> cards) =>
        cards
            .OrderByDescending(c => c.IsWild)
            .ThenByDescending(c => c.Suit.Priority);

    public static IOrderedEnumerable<Card> OrderByRank(this IEnumerable<Card> cards) =>
        cards
            .OrderByDescending(c => c.IsWild)
            .ThenByDescending(c => c.Rank.Value);
}
