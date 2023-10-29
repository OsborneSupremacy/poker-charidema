namespace Poker.Domain.Messaging;

public record PhaseResponse
{
    public required Deck Deck { get; init; }

    public required List<Card> CommunityCards { get; init; }

    public required List<Player> Players { get; init; }
    
    public required List<Player> Winners { get; init; }

    public required bool GameOver { get; init; }

    public required int Pot { get; init; }
}
