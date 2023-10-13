namespace Poker.Domain.Messaging;

public record EvaluatedHandSegmentRequest
{
    public required HandSegment HandSegment { get; init; }

    public required UnusedCardsMessage UnusedCards { get; init; }
}
