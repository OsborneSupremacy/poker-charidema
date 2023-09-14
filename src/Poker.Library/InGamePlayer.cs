namespace Poker.Library;

public record InGamePlayer
{
    public required Player Player { get; init; }

    public required List<ICard> Cards { get; init; }

    public required bool Folded { get; set; }
}

