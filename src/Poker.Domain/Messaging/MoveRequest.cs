namespace Poker.Domain.Messaging;

public record MoveRequest
{
    public required Player PlayerInTurn { get; init; }

    public required PhaseRequest PhaseRequest { get; init; }

    public required uint Pot { get; init; }
}
