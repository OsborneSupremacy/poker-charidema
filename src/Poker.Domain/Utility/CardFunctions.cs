namespace Poker.Domain.Utility;

public static class CardFunctions
{
    public static Rank GetMaxRank(
        IEnumerable<Card> contributingStandardCards,
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
