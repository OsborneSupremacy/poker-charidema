namespace Poker.Library;

public record Bet
{
    public required uint Amount { get; init; }

    public required IPlayer Player { get; init; }
}
