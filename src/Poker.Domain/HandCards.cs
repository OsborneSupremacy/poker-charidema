namespace Poker.Domain;

public record HandCards
{
    [SetsRequiredMembers]
    public HandCards()
    {
        Standard = new List<Card>();
        Wild = new List<DesignatedWildCard>();
    }

    [SetsRequiredMembers]
    public HandCards(List<Card> cards)
    {
        Standard = cards.WhereStandard().ToList();
        Wild = cards.WhereWild()
            .Select(c => new DesignatedWildCard { DesignatedCard = Cards.Empty, WildCard = c })
            .ToList();
    }

    public required List<Card> Standard { get; init; }

    public required List<DesignatedWildCard> Wild { get; init; }
}
