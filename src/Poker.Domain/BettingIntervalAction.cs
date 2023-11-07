namespace Poker.Domain;

public enum BettingIntervalActionType
{
    Empty,
    Check,
    Call,
    Bet,
    Raise,
    Fold
}

public record BettingIntervalAction
{
    public required BettingIntervalActionType BettingIntervalActionType { get; init; }

    public required Guid PlayerId { get; init; }
}
