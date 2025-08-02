namespace Poker.Domain.Messaging;

public record EvaluateHandCollectionRequest
{
    public required Participant Participant { get; init; }

    public required IReadOnlyList<Card> Cards { get; init; }

    public required IReadOnlyList<Hand> HandsToEvaluate { get; init; }

    public required int RemainingCardCount { get; init; }

    public required HandEvaluator HandEvaluator { get; init; }
}
