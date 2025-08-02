namespace Poker.Domain.Messaging;

public record DistributeWinningsResponse
{
    public required IReadOnlyList<Participant> Participants { get; init; }
}
