namespace Poker.Domain.Messaging;

public record ReshuffleRequest
{
    public required List<Player> Players { get; init; }
    
    public required Deck Deck { get; init; }
}
