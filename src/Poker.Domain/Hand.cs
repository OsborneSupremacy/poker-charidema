namespace Poker.Domain;

public record Hand
{
    public required List<Card> Cards { get; init; }
}
