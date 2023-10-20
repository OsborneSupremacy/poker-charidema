namespace Poker.Domain;

public record Deck
{
    public required List<Card> Cards { get; init; }

    public required int NumberOfJokers { get; init; }
}

public static class Decks
{
    public static Deck Empty { get; } = new()
    {
        Cards = new(),
        NumberOfJokers = 0
    };
}
