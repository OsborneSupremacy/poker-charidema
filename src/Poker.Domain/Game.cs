namespace Poker.Domain;

public record Game
{
    public required int Ante { get; init; }

    public required int Pot { get; init; }

    public required Deck Deck { get; init; }

    public required List<CardInPlay> CommunityCards { get; init; }

    public required List<CardInPlay> Discards { get; init; }

    public required List<Player> Players { get; init; }

    public required Player Button { get; init; }

    public required Variant Variant { get; init; }
}

public static class Games
{
    public static Game Empty { get; } = new()
    {
        Ante = 0,
        Pot = 0,
        Deck = Decks.Empty,
        CommunityCards = [],
        Discards = [],
        Players = [],
        Button = Players.Empty,
        Variant = Implementations.Variants.EmptyVariant.GetVariant()
    };
}
