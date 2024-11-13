namespace Poker.Service;

internal class BettingIntervalService : IBettingIntervalService
{
    private readonly IBettingIntervalOptionsService _bettingIntervalOptionsService;

    private readonly IRandomService _randomService;

    public BettingIntervalService(IBettingIntervalOptionsService bettingIntervalOptionsService,
        IRandomService randomService)
    {
        _bettingIntervalOptionsService = bettingIntervalOptionsService ??
                                         throw new ArgumentNullException(nameof(bettingIntervalOptionsService));
        _randomService = randomService ?? throw new ArgumentNullException(nameof(randomService));
    }

    public async Task<BettingIntervalResponse> ExecuteAsync(BettingIntervalRequest request)
    {
        BettingIntervalOptionsRequest optionsRequest = new()
        {
            CurrentBet = request.CurrentBet,
            ActivePlayers = request.ActivePlayers
        };

        var optionsResponse = await _bettingIntervalOptionsService
            .ExecuteAsync(optionsRequest);

        // pick random option
        var option = _randomService
            .PickFromList(optionsResponse.AvailableBettingIntervalActions);

        var optionDelegate = BettingIntervalDelegates[option] ?? Fold;

        var maxBet = request.ActivePlayers.Min(ap => ap.Stack);

        return optionDelegate(
            request,
            () => _randomService.GetAmount(request.CurrentBet.Amount + 1, maxBet)
        );
    }

    private delegate BettingIntervalResponse BettingIntervalDelegate(
        BettingIntervalRequest request,
        Func<int> getAdditionalAmount
        );

    private static readonly BettingIntervalDelegate Bet = (request, getAdditionalAmount) =>
    {
        var betAmount = getAdditionalAmount();

        return new BettingIntervalResponse
        {
            Description = $"Bet {betAmount:C0}",
            CurrentBet = new Bet
            {
                Amount = betAmount,
                InitiatingPlayerId = request.PlayerInTurn.Id,
                CheckedPlayerIds = [],
                ContributingPlayers =
                [
                    new ContributingPlayer { PlayerId = request.PlayerInTurn.Id, Amount = betAmount }
                ],
                TerminalPlayerIds = []
            },
            Pot = request.Pot + betAmount,
            PlayerInTurn = request.PlayerInTurn with
            {
                Stack = request.PlayerInTurn.Stack - betAmount,
                Stake = request.PlayerInTurn.Stake + betAmount
            },
            CloseBetting = false
        };
    };

    private static readonly BettingIntervalDelegate Check = (request, _) =>
    {
        var checkedPlayerIds = request.CurrentBet.CheckedPlayerIds;
        checkedPlayerIds.Add(request.PlayerInTurn.Id);

        var closeBetting =
            checkedPlayerIds.Count >= request.ActivePlayers.NotFolded().Count();

        return new BettingIntervalResponse
        {
            Description = "Checks",
            CurrentBet = request.CurrentBet with
            {
                CheckedPlayerIds = checkedPlayerIds
            },
            Pot = request.Pot,
            PlayerInTurn = request.PlayerInTurn,
            CloseBetting = closeBetting
        };
    };

    private static readonly BettingIntervalDelegate Call = (request, _) =>
    {
        var contributingPlayers = request.CurrentBet.ContributingPlayers;

        var currentContribution = contributingPlayers
            .SingleOrDefault(cp => cp.PlayerId == request.PlayerInTurn.Id);

        if (currentContribution is not null)
            contributingPlayers.Remove(currentContribution);

        var additionalAmount =
            request.CurrentBet.Amount
            - currentContribution?.Amount ?? 0;

        contributingPlayers.Add(new ContributingPlayer
        {
            PlayerId = request.PlayerInTurn.Id,
            Amount = request.CurrentBet.Amount
        });

        var closeBetting =
            contributingPlayers
                .PaidUp(request.CurrentBet.Amount).Count() >= request.ActivePlayers.NotFolded().Count();

        return new BettingIntervalResponse
        {
            Description = "Calls",
            CurrentBet = request.CurrentBet with
            {
                ContributingPlayers = contributingPlayers,
                TerminalPlayerIds = request.CurrentBet.TerminalPlayerIds
            },
            Pot = request.Pot + additionalAmount,
            PlayerInTurn = request.PlayerInTurn with
            {
                Stack = request.PlayerInTurn.Stack - additionalAmount,
                Stake = request.PlayerInTurn.Stake + additionalAmount
            },
            CloseBetting = closeBetting
        };
    };

    private static readonly BettingIntervalDelegate Raise = (request, getAdditionalAmount) =>
    {
        var raiseDelta = getAdditionalAmount();
        var newBetAmount = request.CurrentBet.Amount + raiseDelta;

        var contributingPlayers = request.CurrentBet.ContributingPlayers;

        var currentContribution = contributingPlayers
            .SingleOrDefault(cp => cp.PlayerId == request.PlayerInTurn.Id);

        if (currentContribution is not null)
            contributingPlayers.Remove(currentContribution);

        var playerAdditionalAmount =
            newBetAmount
            - currentContribution?.Amount ?? 0;

        contributingPlayers.Add(new ContributingPlayer
        {
            PlayerId = request.PlayerInTurn.Id,
            Amount = newBetAmount
        });

        return new BettingIntervalResponse
        {
            Description = $"Raises {playerAdditionalAmount:C0}",
            CurrentBet = new Bet
            {
                Amount = newBetAmount,
                InitiatingPlayerId = request.PlayerInTurn.Id,
                CheckedPlayerIds = [],
                ContributingPlayers = contributingPlayers,
                TerminalPlayerIds = []
            },
            Pot = request.Pot + playerAdditionalAmount,
            PlayerInTurn = request.PlayerInTurn with
            {
                Stack = request.PlayerInTurn.Stack - playerAdditionalAmount,
                Stake = request.PlayerInTurn.Stake + playerAdditionalAmount
            },
            CloseBetting = false
        };
    };

    private static readonly BettingIntervalDelegate Fold = (request, _) =>
    {
        // if only one player remains, close betting.
        var closeBetting = (request.ActivePlayers.NotFolded().Count() - 1) == 1;

        return new BettingIntervalResponse
        {
            Description = "Folds",
            CurrentBet = request.CurrentBet,
            Pot = request.Pot,
            PlayerInTurn = request.PlayerInTurn with { Folded = true },
            CloseBetting = closeBetting
        };
    };

    private static readonly Dictionary<BettingIntervalActionType, BettingIntervalDelegate?> BettingIntervalDelegates =
        new()
        {
            { BettingIntervalActionType.Bet, Bet },
            { BettingIntervalActionType.Check, Check },
            { BettingIntervalActionType.Call, Call },
            { BettingIntervalActionType.Raise, Raise },
            { BettingIntervalActionType.Fold, Fold }
        };
}
