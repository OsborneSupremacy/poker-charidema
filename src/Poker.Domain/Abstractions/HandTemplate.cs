namespace Poker.Domain.Abstractions;


public record HandTemplate
{
    public required string Name { get; init; }

    public required Hand Hand { get; init; }

    public required Rank HighRank { get; init; }

    public required Suit Suit { get; init; }

    public required List<CardGroup> CardGroups { get; init; }
}
