namespace Poker.Domain.Messaging;

public record EvaluatedHandCollectionRequest
{
    public required Player Player { get; init; }
    
    public required List<Card> Cards { get; init; }

    public required List<Hand> HandsToEvaluate { get; init; }

    public required int RemainingCardCount { get; init; }

    public required HandEvaluator HandEvaluator { get; init; }
}
