namespace Poker.Domain;

public record HandSegment
{
    public required int RequiredCount { get; init; }

    public required List<Card> EligibleCards { get; init; }
}
