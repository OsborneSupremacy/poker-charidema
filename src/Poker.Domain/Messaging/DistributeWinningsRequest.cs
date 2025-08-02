namespace Poker.Domain.Messaging;

public record DistributeWinningsRequest
{
    public required IReadOnlyList<Participant> Participants { get; init; }

    public required IReadOnlyList<Participant> Winners { get; init; }

    public required int Pot { get; init; }
}
