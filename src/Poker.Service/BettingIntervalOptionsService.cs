namespace Poker.Service;

public class BettingIntervalOptionsService : IBettingIntervalOptionsService
{
    public Task<BettingIntervalOptionsResponse> ExecuteAsync(BettingIntervalOptionsRequest request)
    {
        List<BettingIntervalActionType> actions = (request.CurrentBet == Bets.Empty) switch
        {
            true => new()
            {
                BettingIntervalActionType.Check,
                BettingIntervalActionType.Bet
            },
            false => new()
            {
                BettingIntervalActionType.Call,
                BettingIntervalActionType.Raise,
                BettingIntervalActionType.Fold
            }
        };

        return Task.FromResult(new BettingIntervalOptionsResponse
        {
            RequiredAmountToCall = request.CurrentBet.Amount,
            // we're currently going to prevent a player from better more
            // than another player has.
            MaximumBet = request.ActivePlayers.Max(p => p.Stack),
            AvailableBettingIntervalActions = actions
        });
    }
}
