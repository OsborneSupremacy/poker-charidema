namespace Poker.Service;

/// <inheritdoc />
internal class BettingIntervalOptionsService : IBettingIntervalOptionsService
{
    public Task<BettingIntervalOptionsResponse> ExecuteAsync(BettingIntervalOptionsRequest request)
    {
        // need to make this make sense

        List<BettingIntervalActionType> actions = (request.CurrentBet == Bets.Empty) switch
        {
            true =>
            [
                BettingIntervalActionType.Check,
                BettingIntervalActionType.Bet
            ],
            false =>
            [
                BettingIntervalActionType.Call,
                BettingIntervalActionType.Raise,
                BettingIntervalActionType.Fold
            ]
        };

        return Task.FromResult(new BettingIntervalOptionsResponse
        {
            RequiredAmountToCall = request.CurrentBet.Amount,
            // we're currently going to prevent a player from betting more
            // than another player has.
            MaximumBet = request.ActivePlayers.Min(p => p.Stack),
            AvailableBettingIntervalActions = actions
        });
    }
}
