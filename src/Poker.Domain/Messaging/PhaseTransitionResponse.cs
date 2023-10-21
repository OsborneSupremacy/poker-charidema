namespace Poker.Domain.Messaging;

public record PhaseTransitionResponse
{
    public required PhaseResponse PhaseResponse { get; init; }
    
    public required GameResponse GameResponse { get; init; }
}


