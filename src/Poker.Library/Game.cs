namespace Poker.Library;

public record Game
{
    public required IVariant Variant { get; init; }

    public required uint Ante { get; init; }

    public required uint Pot { get; init; }

    public required IDeck Deck { get; init; }

    public required List<ICard> CommunityCards { get; init; }

    public required List<ICard> Discards { get; init; }

    public required List<Player> Players { get; init; }

    public required Player Button { get; init; }
}
