namespace Poker.Domain;

public record Bet
{
    public required int Amount { get; init; }

    public required Player Player { get; init; }
}
