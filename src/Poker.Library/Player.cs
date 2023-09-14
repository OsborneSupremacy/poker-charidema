namespace Poker.Library;

public record Player
{
    public required Participant Participant { get; init; }

    public required List<ICard> Cards { get; init; }

    public required bool Folded { get; set; }
}

