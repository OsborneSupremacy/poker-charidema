namespace Poker.Domain.Messaging;

public record MoveRequest
{
    public required Player PlayerInTurn { get; init; }

    public required PhaseRequest PhaseRequest { get; init; }

    public required int Pot { get; init; }
}
