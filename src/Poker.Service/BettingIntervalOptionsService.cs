namespace Poker.Service;

/// <inheritdoc />
internal class BettingIntervalOptionsService : IBettingIntervalOptionsService
{
    public Task<BettingIntervalOptionsResponse> ExecuteAsync(BettingIntervalOptionsRequest request)
    {
        var noBet = (request.CurrentBet.Amount == 0);

        #if DEBUG
        if (noBet)
            Console.WriteLine("No current bet.");
        #endif

        List<BettingIntervalActionType> actions = (noBet) switch
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
            MaximumBet = request.ActiveParticipants.Min(p => p.Stack),
            AvailableBettingIntervalActions = actions
        });
    }
}
