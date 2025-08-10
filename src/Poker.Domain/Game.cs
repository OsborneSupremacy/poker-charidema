namespace Poker.Domain;

public record Game
{
    public required Guid Id { get; init; }

    public required int GameNumber { get; init; }

    public required int Ante { get; init; }

    public required int Pot { get; init; }

    public required Deck Deck { get; init; }

    public required IReadOnlyList<CardInPlay> CommunityCards { get; init; }

    public required IReadOnlyList<CardInPlay> Discards { get; init; }

    public required IReadOnlyList<Participant> Participants { get; init; }

    public required Participant Button { get; init; }

    public required Variant Variant { get; init; }
}

public static class Games
{
    public static Game Empty { get; } = new()
    {
        Id = Guid.Empty,
        GameNumber = 0,
        Ante = 0,
        Pot = 0,
        Deck = Decks.Empty,
        CommunityCards = [],
        Discards = [],
        Participants = [],
        Button = Participants.Empty,
        Variant = Implementations.Variants.EmptyVariant.GetVariant()
    };
}
