namespace Poker.Domain.Messaging;

public record EvaluateHandRequest
{
    public required Player Player { get; init; }

    public required List<Card> Cards { get; init; }

    public required Hand HandToEvaluate { get; init; }

    public required int RemainingCardCount { get; init; }
}
