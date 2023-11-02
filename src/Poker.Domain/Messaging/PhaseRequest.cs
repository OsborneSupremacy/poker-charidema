namespace Poker.Domain.Messaging;

public record PhaseRequest
{
    public required Game Game { get; init; }
    
    public required Phase Phase { get; init; }

    public required Deck Deck { get; init; }

    public required List<Card> CommunityCards { get; init; }

    public required Player StartingPlayer { get; init; }

    public required int Pot { get; init; }
}
