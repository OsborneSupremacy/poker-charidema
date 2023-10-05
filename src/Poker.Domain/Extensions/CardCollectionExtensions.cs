namespace Poker.Domain.Extensions;

public static class CardCollectionExtensions
{
    public static IEnumerable<AssignedWildCard> AssignWildCards(
        this Queue<Card> wildCards,
        Queue<Card> targets
        )
    {
        while (
            targets.Any()
            && wildCards.Any()
            )
            yield return
                new AssignedWildCard()
                {
                    WildCard = wildCards.Dequeue(),
                    StandardCard = targets.Dequeue()
                };
    }

    public static bool HasCountOfMatchingRankOrWild(this List<Card> input, Rank rank, uint count) =>
        input.WhereRanksOrIsWild(rank).Count() >= count;

    public static Rank GetMaxRank(
        this IEnumerable<Card> contributingStandardCards,
        IEnumerable<AssignedWildCard> contributingWildCards
        )
    {
        var cards = contributingStandardCards
            .Concat(
                contributingWildCards.Select(w => w.StandardCard)
            )
            .ToList();

        return cards.Any() switch
        {
            true => cards
                .Where(c => c.Rank.Value == cards.Max(c => c.Rank.Value))
                .Select(c => c.Rank)
                .First(),
            false => Ranks.Empty
        };
    }
}
