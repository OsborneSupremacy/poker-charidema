namespace Poker.Library;

public record HandPlayer : Player
{
    public List<Card> Cards { get; init; }

    public bool Folded { get; init; }
}
