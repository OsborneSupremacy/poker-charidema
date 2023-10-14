namespace Poker.Domain.Extensions;

public static class DesignatedWildCardExtensions
{
    public static IEnumerable<Card> DesignatedCards(
        this IEnumerable<DesignatedWildCard> designatedWildCards
        ) =>
        designatedWildCards.Select(x => x.DesignatedCard);
}
