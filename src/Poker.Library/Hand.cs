using Poker.Library.Cards;

namespace Poker.Library;

public record Hand
{
    public List<Card> Cards { get; init; }
}
