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

        var maximumBet = GetMaximumBet(request);

        return Task.FromResult(new BettingIntervalOptionsResponse
        {
            RequiredAmountToCall = request.CurrentBet.Amount,
            MaximumBet = maximumBet,
            AvailableBettingIntervalActions = options
        });
    }

    private static int GetMaximumBet(BettingIntervalOptionsRequest request) =>
        Math.Min(MinimumPlayerStack(request), PlayerInTurnStack(request));

    private static readonly Predicate<BettingIntervalOptionsRequest> FoldIsAnOption = request =>
        ThereIsABet!(request) && PlayerInTurnNeedsToContributeMoreToStayIn!(request);

    private static readonly Predicate<BettingIntervalOptionsRequest> ThereIsABet = request =>
        request.CurrentBet.Amount > 0;

    private static readonly Predicate<BettingIntervalOptionsRequest> PlayerInTurnNeedsToContributeMoreToStayIn = request =>
        request.CurrentBet.Amount > PlayerInTurnStake!(request);

    private static readonly Func<BettingIntervalOptionsRequest, int> MinimumPlayerStack = request =>
        request.ActiveParticipants.Min(p => p.Stack);

    private static readonly Func<BettingIntervalOptionsRequest, int> PlayerInTurnStake = request =>
        request.CurrentBet.PlayerContributions[request.ParticipantInTurnId];

    private static readonly Func<BettingIntervalOptionsRequest, int> PlayerInTurnStack = request =>
        request.ActiveParticipants
            .Where(p => p.Id == request.ParticipantInTurnId)
            .Select(p => p.Stack)
            .Single();
}
