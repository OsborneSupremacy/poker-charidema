namespace Poker.Domain;

public record Game
{
    public required uint Ante { get; init; }

    public required uint Pot { get; init; }

    public required Deck Deck { get; init; }

    public required List<Card> CommunityCards { get; init; }

    public required List<Card> Discards { get; init; }

    public required List<Player> Players { get; init; }

    public required Player Button { get; init; }

    public required Variant Variant { get; init; }
}
