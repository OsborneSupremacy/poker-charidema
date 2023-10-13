namespace Poker.Domain;

public record HandCards
{
    [SetsRequiredMembers]
    public HandCards()
    {
        Standard = new List<Card>();
        Wild = new List<AssignedWildCard>();
    }

    [SetsRequiredMembers]
    public HandCards(List<Card> cards)
    {
        Standard = cards.WhereStandard().ToList();
        Wild = cards.WhereWild()
            .Select(c => new AssignedWildCard { StandardCard = Cards.Empty, WildCard = c })
            .ToList();
    }

    public required List<Card> Standard { get; init; }

    public required List<AssignedWildCard> Wild { get; init; }
}
