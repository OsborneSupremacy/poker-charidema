namespace Poker.Domain.Messaging;

public record BetRequest
{
    public required int CurrentBet { get; init; }
    
    public required int Pot { get; init; }
}
