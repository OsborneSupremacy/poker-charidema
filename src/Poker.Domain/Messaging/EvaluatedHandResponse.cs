namespace Poker.Domain.Messaging;

public record EvaluatedHandResponse
{
    public required Player Player { get; init; }

    public required Hand Hand { get; init; }

    public required HandQualifications HandQualification { get; init; }

    public required List<EvaluateHandSegmentResponse> EvaluatedHandSegments { get; init; }

    public required UnusedCardsMessage UnusedCards { get; init; }

    public required int RemainingCardCount { get; init; }
}
