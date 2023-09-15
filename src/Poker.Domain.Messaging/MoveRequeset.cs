namespace Poker.Domain.Messaging;

public record MoveRequeset
{
    public required Player PlayerInTurn { get; init; }

    public required PhaseRequest PhaseRequest { get; init; }

    public required uint Pot { get; init; }
}
