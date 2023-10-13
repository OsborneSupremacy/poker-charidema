namespace Poker.Domain.Classic;

public record Hand
{
    public required string Name { get; init; }

    public required HandDefinition HandDefinition { get; init; }

    public required Rank HighRank { get; init; }

    public required Suit Suit { get; init; }

    public required List<CardGroup> CardGroups { get; init; }
}
