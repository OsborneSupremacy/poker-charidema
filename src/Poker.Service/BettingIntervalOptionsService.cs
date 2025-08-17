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

            if(!APlayerIsAllIn(request)) // can't raise if someone is all-in
                options.Add(BettingIntervalActionType.Raise);

            if(FoldIsAnOption(request))
                options.Add(BettingIntervalActionType.Fold);
        }
        else
        {
            options.Add(BettingIntervalActionType.Check);

            if(!APlayerIsAllIn(request)) // can't raise if someone is all-in
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

    private static int GetMaximumBet(BettingIntervalOptionsRequest request)
    {
        var maxBet = Math.Min(MaxBettableAmount(request), PlayerInTurnStack(request));

        // needs to take into account the current bet
        // e.g. Sally has a stack of $100, making that the max bet
        // Joe raises by $100. Sally hasn't checked yet, so she still has $100 in her stack.
        // When calculating the maximum bet for Steve, it still looks like he can raise by $100 since Sally hasn't checked yet.

#if DEBUG
        Console.WriteLine();
        Console.WriteLine("  - Determining maximum bet.");
        Console.WriteLine("    - Player stacks (* = player in turn):");
        foreach (var player in request.ActiveParticipants)
        {
            Console.WriteLine(request.ParticipantInTurnId == player.Id
                ? $"      - * {player.Name}: {player.Stack:C0}"
                : $"      - {player.Name}: {player.Stack:C0}");
        }
        Console.WriteLine();
#endif
        return maxBet;
    }

    private static readonly Predicate<BettingIntervalOptionsRequest> FoldIsAnOption = request =>
        ThereIsABet!(request) && PlayerInTurnNeedsToContributeMoreToStayIn!(request);

    private static readonly Predicate<BettingIntervalOptionsRequest> ThereIsABet = request =>
        request.CurrentBet.Amount > 0;

    private static readonly Predicate<BettingIntervalOptionsRequest> PlayerInTurnNeedsToContributeMoreToStayIn = request =>
        request.CurrentBet.Amount > PlayerInTurnStake!(request);

    private static readonly Predicate<BettingIntervalOptionsRequest> APlayerIsAllIn = request =>
        request.APlayerIsAllIn;

    private static readonly Func<BettingIntervalOptionsRequest, int> MaxBettableAmount = request =>
    {
        var playerFunds = new List<int>();

        var currentBet = request.CurrentBet.Amount;

        foreach(var player in request.ActiveParticipants.NotFolded())
        {
            var availableFunds = player.Stack;
            var neededToCallAmount = player.Stake - currentBet;

            if(neededToCallAmount > 0)
                availableFunds -= neededToCallAmount;

            playerFunds.Add(availableFunds);
        }

        return playerFunds.Min();
    };

    private static readonly Func<BettingIntervalOptionsRequest, int> PlayerInTurnStake = request =>
        request.CurrentBet.PlayerContributions[request.ParticipantInTurnId];

    private static readonly Func<BettingIntervalOptionsRequest, int> PlayerInTurnStack = request =>
        request.ActiveParticipants
            .Where(p => p.Id == request.ParticipantInTurnId)
            .Select(p => p.Stack)
            .Single();
}
