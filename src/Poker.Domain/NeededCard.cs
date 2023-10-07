namespace Poker.Domain;

public record NeededCard
{
    public required Rank Rank { get; init; }

    public required Suit Suit { get; init; }
}
