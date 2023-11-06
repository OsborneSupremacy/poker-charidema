namespace Poker.Domain;

public enum BetType
{
    Empty,
    Check,
    Call,
    Bet,
    Raise,
    Fold
}

public record Bet
{
    public required int Amount { get; init; }
    
    public required BetType Type { get; init; }

    public required Guid PlayerId { get; init; }
}
