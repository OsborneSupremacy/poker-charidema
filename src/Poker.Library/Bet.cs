namespace Poker.Library;

public record Bet
{
    public double Amount { get; init; }

    public Player Player { get; init; }
}
