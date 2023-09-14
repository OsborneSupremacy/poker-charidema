namespace Poker.Library;

public record Bet
{
    public required uint Amount { get; init; }

    public required Player Player { get; init; }
}
