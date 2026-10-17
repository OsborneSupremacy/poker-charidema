namespace Poker.Domain.Messaging;

public record BettingIntervalActionSelectionResponse
{
    public required BettingIntervalActionType BettingIntervalActionType { get; init; }

    /// <summary>
    /// The amount the participant is adding to the current bet. Only used when betting or raising.
    /// </summary>
    public required int Amount { get; init; }
}
