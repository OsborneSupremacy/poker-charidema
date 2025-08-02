namespace Poker.Domain.Messaging;

public record DistributeWinningsRequest
{
    public required List<Participant> Participants { get; init; }

    public required List<Participant> Winners { get; init; }

    public required int Pot { get; init; }
}
