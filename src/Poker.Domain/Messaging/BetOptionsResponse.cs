namespace Poker.Domain.Messaging;

public class BetOptionsResponse
{
    public required int MinimumBet { get; init; }
    
    public required int MaximumBet { get; init; }
    
    public required List<BetType> AvailableBetTypes { get; init; }
}
