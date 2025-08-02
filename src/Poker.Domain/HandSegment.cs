namespace Poker.Domain;

public record HandSegment
{
    public required int RequiredCount { get; init; }

    public required IReadOnlyList<Card> EligibleCards { get; init; }
}
