namespace Poker.Domain;

public record Player
{
    public required Participant Participant { get; init; }

    public required List<Card> Cards { get; init; }

    public required bool Folded { get; set; }
}

