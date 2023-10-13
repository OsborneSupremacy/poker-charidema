namespace Poker.Domain.Classic;

public record HandSegment
{
    public required int RequiredCount { get; init; }

    public required List<Card> EligibleCards { get; init; }
}
