using Poker.Library.Cards;

namespace Poker.Library;

public record HandPlayer : Player
{
    public required List<Card> Cards { get; init; }

    public bool Folded { get; init; }
}
