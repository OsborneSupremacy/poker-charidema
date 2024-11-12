namespace Poker.Domain.Messaging;

public record BettingIntervalOptionsResponse
{
    /// <summary>
    /// The amount required for the current better to call the current bet.
    /// </summary>
    public required int RequiredAmountToCall { get; init; }

    public required int MaximumBet { get; init; }

    public required List<BettingIntervalActionType> AvailableBettingIntervalActions { get; init; }
}
