namespace Poker.Domain.Messaging;

public record CoordinatePhaseResponse
{
    public required PhaseResponse PhaseResponse { get; init; }

    public required GameResponse GameResponse { get; init; }
}


