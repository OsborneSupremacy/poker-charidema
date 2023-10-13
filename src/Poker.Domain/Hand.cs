namespace Poker.Domain;

public record Hand
{
    public required string Name { get; init; }

    public required HandDefinition HandDefinition { get; init; }

    public required Rank HighRank { get; init; }

    public required Suit Suit { get; init; }

    public required List<HandSegment> HandSegments { get; init; }
}
