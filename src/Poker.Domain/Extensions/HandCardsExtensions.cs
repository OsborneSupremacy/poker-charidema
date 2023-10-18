namespace Poker.Domain.Extensions;

public static class HandCardsExtensions
{
    public static int Count(this HandCards handCards) =>
        handCards.Standard.Count + handCards.Wild.Count;

    public static List<Card> AllStandardized(this HandCards handCards) =>
        handCards.Standard
            .Concat(handCards.Wild.Select(c => c.DesignatedCard))
            .ToList();

    public static void Add(this HandCards handCards, Card card) =>
        handCards.Standard.Add(card);

    public static void Add(
        this HandCards handCards,
        Card wildCard,
        Card standardCard
        ) =>
            handCards.Wild.Add(new()
            {
                WildCard = wildCard,
                DesignatedCard = standardCard
            });

    public static HandCards Combine(this IEnumerable<HandCards> handCards)
    {
        List<Card> standard = new();
        List<DesignatedWildCard> wildCards = new();

        foreach(var handCard in handCards)
        {
            standard.AddRange(handCard.Standard);
            wildCards.AddRange(handCard.Wild);
        };

        return new HandCards
        {
            Standard = standard,
            Wild = wildCards
        };
    }
}
