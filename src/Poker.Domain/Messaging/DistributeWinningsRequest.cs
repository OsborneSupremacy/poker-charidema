namespace Poker.Domain.Messaging;

public record DistributeWinningsRequest
{
    public required List<Player> Players { get; init; }
    
    public required List<Player> Winners { get; init; }
    
    public required int Pot { get; init; }
}
