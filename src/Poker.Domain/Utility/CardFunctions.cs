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

    public static List<Card> GetNonContributingCards(
        IEnumerable<Card> allCards,
        IEnumerable<Card> contributingStandard,
        IEnumerable<AssignedWildCard> contributingWild
        ) =>
            allCards
                .Except(contributingStandard.ToList())
                .Except(contributingWild.Select(w => w.WildCard))
                .ToList();
}
