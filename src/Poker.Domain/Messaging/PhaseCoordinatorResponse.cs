namespace Poker.Domain.Messaging;

public record PhaseCoordinatorResponse
{
    public required PhaseResponse PhaseResponse { get; init; }
    
    public required GameResponse GameResponse { get; init; }
}


