namespace Poker.Domain;

public record Deck
{
    public required List<Card> Cards { get; init; }

    public required uint NumberOfJokers { get; init; }

    public required List<uint> CardRankValues { get; init; }

    public required List<uint> CardSuitPriorities { get; init; }
}

