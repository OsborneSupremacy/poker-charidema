namespace Poker.Domain.Messaging;

public record QualifiedHandRequest
{
    public required Hand Hand { get; init; }

    public required List<Card> Cards { get; init; }

    public required uint RemainingCardCount { get; init; }
}
