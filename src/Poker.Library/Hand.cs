using Poker.Library.Cards;

namespace Poker.Library;

public record Hand
{
    public required List<ICard> Cards { get; init; }
}
