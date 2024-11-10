namespace Poker.Domain.Messaging;

public record DealResponse
{
    public required Deck Deck { get; init; }

    public required List<Player> Players { get; init; }

    public required List<Card> CommunityCards { get; init; }
}
