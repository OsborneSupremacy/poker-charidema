namespace Poker.Domain;

public record PlayerHand
{
    public required Hand Hand { get; init; }

    public required HandCards HandCards { get; init; }

    public required List<Card> Kickers { get; init; }

    public required List<Card> DeadCards { get; init; }
}
