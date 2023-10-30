namespace Poker.Domain.Messaging;

public record EvaluateHandSegmentRequest
{
    public required HandSegment HandSegment { get; init; }

    public required UnusedCardsMessage UnusedCards { get; init; }
}
