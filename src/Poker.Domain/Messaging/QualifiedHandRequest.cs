namespace Poker.Domain.Messaging;

public record QualifiedHandRequest
{
    public required HandDefinition Hand { get; init; }

    public required List<Card> Cards { get; init; }

    public required int RemainingCardCount { get; init; }
}
