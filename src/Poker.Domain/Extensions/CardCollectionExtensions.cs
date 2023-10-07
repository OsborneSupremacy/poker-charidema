namespace Poker.Domain.Extensions;

internal static class CardCollectionExtensions
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

    public static string AggregateValue(this IEnumerable<Card> cards) =>
        string.Join('|', cards.Select(c => c.Value).OrderBy(v => v));
}
