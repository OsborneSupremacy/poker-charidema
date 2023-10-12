namespace Poker.Domain.Extensions;

public static class AssignedWildCardExtensions
{
    public static IEnumerable<Card> AssignedCards(
        this IEnumerable<AssignedWildCard> assignedWildCards
        ) =>
        assignedWildCards.Select(x => x.StandardCard);
}
