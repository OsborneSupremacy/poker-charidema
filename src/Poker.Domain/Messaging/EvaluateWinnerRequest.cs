namespace Poker.Domain.Messaging;

public record EvaluateWinnerRequest
{
    public required Game Game { get; init; }
}
