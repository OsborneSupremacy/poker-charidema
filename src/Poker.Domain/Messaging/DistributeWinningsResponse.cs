namespace Poker.Domain.Messaging;

public record DistributeWinningsResponse
{
    public required List<Player> Players { get; init; }
}
