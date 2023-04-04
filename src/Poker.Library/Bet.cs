namespace Poker.Library;

public record Bet
{
    public required double Amount { get; init; }

    public required IPlayer Player { get; init; }
}
