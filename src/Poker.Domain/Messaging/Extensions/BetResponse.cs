namespace Poker.Domain.Messaging.Extensions;

public record BetResponse
{
    public required int Amount { get; init; }
    
    public required int Pot { get; init; }
}
