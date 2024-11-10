namespace Poker.Domain.Messaging;

public record EvaluateWinnerRequest
{
    public required List<Player> Players { get; init; }

    public required HandCollectionEvaluator HandCollectionEvaluator { get; init; }

    public required HandEvaluator HandEvaluator { get; init; }
}
