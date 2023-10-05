namespace Poker.Domain.Extensions;

public static class AssignedWildCardCollectionExtensions
{
    public static List<Card> GetImpersonatingCards(
        this List<AssignedWildCard> assignedWildCards
    ) =>
        assignedWildCards
            .Select(assignedWildCard => assignedWildCard.StandardCard)
            .ToList();
}
