namespace Poker.Library;

public record Player : Person
{
    public List<Card> Cards { get; init; }

    public double Stack { get; init; }
}
