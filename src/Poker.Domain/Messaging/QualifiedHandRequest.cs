namespace Poker.Domain.Messaging;

public record QualifiedHandRequest
{
    public required HandDefinition Hand { get; init; }

    public required List<Card> Cards { get; init; }

    public required uint RemainingCardCount { get; init; }
}
