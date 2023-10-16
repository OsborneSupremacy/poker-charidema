namespace Poker.Domain;

public record Deck
{
    public required List<Card> Cards { get; init; }

    public required int NumberOfJokers { get; init; }
}

