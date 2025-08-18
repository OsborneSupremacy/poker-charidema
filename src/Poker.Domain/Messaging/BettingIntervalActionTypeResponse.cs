namespace Poker.Domain.Messaging;

public record BettingIntervalActionTypeResponse : IWeightedItem
{
    public required BettingIntervalActionType BettingIntervalActionType { get; init; }

    /// <summary>
    /// The likelihood of this action being chosen by the player. Scale from 1 to 100, where 100 is the most likely.
    /// </summary>
    public required int Weight { get; init; }
}
