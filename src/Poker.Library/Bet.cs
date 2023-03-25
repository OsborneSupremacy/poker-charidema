namespace Poker.Library;

public record Bet
{
    public required double Amount { get; init; }

    public required Player Player { get; init; }
}
