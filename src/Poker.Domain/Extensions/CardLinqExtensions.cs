using System.Net.NetworkInformation;

namespace Poker.Domain.Extensions;

public static class CardLinqExtensions
{
    public static IEnumerable<Card> WithoutImpersonation(this IEnumerable<Card> cards) =>
        cards.Select(c => c with { Impersonating = Cards.Empty });

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

    public static IEnumerable<Card> SelectImpersonationTargets(this IEnumerable<Card> cards) =>
        cards
            .Where(x => x.Impersonating != Cards.Empty)
            .Select(x => x.Impersonating);

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
