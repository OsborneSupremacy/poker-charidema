namespace Poker.Domain.Messaging;

public record EvaluateHandRequest
{
    public required Participant Participant { get; init; }

    public required IReadOnlyList<Card> Cards { get; init; }

    public required Hand HandToEvaluate { get; init; }

    public required int RemainingCardCount { get; init; }
}
