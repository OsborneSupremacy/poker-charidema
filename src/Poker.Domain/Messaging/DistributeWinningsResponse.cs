namespace Poker.Domain.Messaging;

public record DistributeWinningsResponse
{
    public required List<Participant> Participants { get; init; }
}
