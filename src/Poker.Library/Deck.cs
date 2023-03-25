namespace Poker.Library;

public record Deck
{
    public required List<ICard> Cards { get; init; }
}

