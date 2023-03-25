using Poker.Library.Cards;

namespace Poker.Library;

public record Hand
{
    public required List<Card> Cards { get; init; }
}
