namespace Poker.Domain.Messaging;

public record EvaluateWinnerRequest
{
    public required IReadOnlyList<Participant> Participants { get; init; }

    public required HandCollectionEvaluator HandCollectionEvaluator { get; init; }

    public required HandEvaluator HandEvaluator { get; init; }
}
