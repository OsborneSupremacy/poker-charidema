namespace Poker.Service;

/// <inheritdoc />
internal class BettingIntervalOptionsService : IBettingIntervalOptionsService
{
    public Task<BettingIntervalOptionsResponse> ExecuteAsync(BettingIntervalOptionsRequest request)
    {
        List<BettingIntervalActionType> options = [];

        if (ThereIsABet(request))
        {
            options.Add(BettingIntervalActionType.Call);
            options.Add(BettingIntervalActionType.Raise);
            if(FoldIsAnOption(request))
                options.Add(BettingIntervalActionType.Fold);
        }
        else
        {
            options.Add(BettingIntervalActionType.Check);
            options.Add(BettingIntervalActionType.Bet);
        }

        return Task.FromResult(new BettingIntervalOptionsResponse
        {
            RequiredAmountToCall = request.CurrentBet.Amount,
            // we're currently going to prevent a player from betting more
            // than another player has.
            MaximumBet = request.ActiveParticipants.Min(p => p.Stack),
            AvailableBettingIntervalActions = options
        });
    }

    private static readonly Predicate<BettingIntervalOptionsRequest> FoldIsAnOption = request =>
        ThereIsABet!(request) && PlayerInTurnNeedsToContributeMoreToStayIn!(request);

    private static readonly Predicate<BettingIntervalOptionsRequest> ThereIsABet = request =>
        request.CurrentBet.Amount > 0;

    private static readonly Predicate<BettingIntervalOptionsRequest> PlayerInTurnNeedsToContributeMoreToStayIn = request =>
        request.CurrentBet.Amount > PlayerInTurnStake!(request);

    private static readonly Func<BettingIntervalOptionsRequest, int> PlayerInTurnStake = request =>
        request.CurrentBet.ContributingPlayers.SingleOrDefault(p => p.PlayerId == request.ParticipantInTurnId)?.Amount ?? 0;
}
