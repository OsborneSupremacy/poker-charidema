namespace Poker.Domain.Messaging;

public record BettingIntervalOptionsResponse
{
    public required int RequiredAmountToCall { get; init; }

    public required int MaximumBet { get; init; }
    
    public required List<BettingIntervalActionType> AvailableBettingIntervalActions { get; init; }
}
