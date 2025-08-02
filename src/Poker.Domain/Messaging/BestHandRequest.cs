namespace Poker.Domain.Messaging;

public record BestHandRequest
{
    public required Participant Participant { get; init; }

    public required int RemainingCardCount { get; init; }

    public required HandCollectionEvaluator HandCollectionEvaluator { get; init; }

    public required HandEvaluator HandEvaluator { get; init; }
}
