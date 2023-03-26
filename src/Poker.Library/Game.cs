using Poker.Library.Cards;

namespace Poker.Library;

public record Game
{
    public required IVariant Variant { get; init; }

    public double Ante { get; init; }

    public double Pot { get; init; }

    public required Deck Deck { get; init; }

    public required List<Card> CommunityCards { get; init; }

    public required List<Card> Discards { get; init; }

    public required List<Player> Players { get; init; }

    public required List<Round> Rounds { get; init; }
}
