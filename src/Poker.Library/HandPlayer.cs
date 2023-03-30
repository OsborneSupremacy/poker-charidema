namespace Poker.Library;

public record HandPlayer : Player
{
    public required List<ICard> Cards { get; init; }

    public bool Folded { get; init; }
}
