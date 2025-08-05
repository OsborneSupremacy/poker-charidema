namespace Poker.Service;

/// <inheritdoc />
internal class BettingIntervalService : IBettingIntervalService
{
    private readonly IBettingIntervalOptionsService _bettingIntervalOptionsService;

    private readonly IRandomService _randomService;

    public BettingIntervalService(
        IBettingIntervalOptionsService bettingIntervalOptionsService,
        IRandomService randomService
        )
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
            ActiveParticipants = request.ActiveParticipants
        };

        var optionsResponse = await _bettingIntervalOptionsService
            .ExecuteAsync(optionsRequest);

        // pick random option
        var option = _randomService
            .PickFromReadOnlyList(optionsResponse.AvailableBettingIntervalActions);

        var optionDelegate = BettingIntervalDelegates[option] ?? Fold;

        var maxBet = request.ActiveParticipants.Min(ap => ap.Stack);

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
            Description = $"Bets {betAmount:C0}",
            CurrentBet = new Bet
            {
                Amount = betAmount,
                InitiatingPlayerId = request.ParticipantInTurn.Id,
                CheckedPlayerIds = [],
                ContributingPlayers =
                [
                    new ContributingPlayer { PlayerId = request.ParticipantInTurn.Id, Amount = betAmount }
                ],
                TerminalPlayerIds = []
            },
            Pot = request.Pot + betAmount,
            ParticipantInTurn = request.ParticipantInTurn with
            {
                Stack = request.ParticipantInTurn.Stack - betAmount,
                Stake = request.ParticipantInTurn.Stake + betAmount
            },
            CloseBetting = false
        };
    };

    private static readonly BettingIntervalDelegate Check = (request, _) =>
    {
        var checkedPlayerIds = request.CurrentBet.CheckedPlayerIds.ToList();
        checkedPlayerIds.Add(request.ParticipantInTurn.Id);

        var closeBetting =
            checkedPlayerIds.Count >= request.ActiveParticipants.NotFolded().Count();

        return new BettingIntervalResponse
        {
            Description = "Checks",
            CurrentBet = request.CurrentBet with
            {
                CheckedPlayerIds = checkedPlayerIds
            },
            Pot = request.Pot,
            ParticipantInTurn = request.ParticipantInTurn,
            CloseBetting = closeBetting
        };
    };

    private static readonly BettingIntervalDelegate Call = (request, _) =>
    {
        var contributingPlayers = request.CurrentBet.ContributingPlayers.ToList();

        var currentContribution = contributingPlayers
            .SingleOrDefault(cp => cp.PlayerId == request.ParticipantInTurn.Id);

        if (currentContribution is not null)
            contributingPlayers.Remove(currentContribution);

        var additionalAmount =
            request.CurrentBet.Amount
            - (currentContribution?.Amount ?? 0);

        contributingPlayers.Add(new ContributingPlayer
        {
            PlayerId = request.ParticipantInTurn.Id,
            Amount = request.CurrentBet.Amount
        });

        var closeBetting =
            contributingPlayers
                .PaidUp(request.CurrentBet.Amount).Count() >= request.ActiveParticipants.NotFolded().Count();

        return new BettingIntervalResponse
        {
            Description = $"Calls with {additionalAmount:C0}",
            CurrentBet = request.CurrentBet with
            {
                ContributingPlayers = contributingPlayers,
                TerminalPlayerIds = request.CurrentBet.TerminalPlayerIds
            },
            Pot = request.Pot + additionalAmount,
            ParticipantInTurn = request.ParticipantInTurn with
            {
                Stack = request.ParticipantInTurn.Stack - additionalAmount,
                Stake = request.ParticipantInTurn.Stake + additionalAmount
            },
            CloseBetting = closeBetting
        };
    };

    private static readonly BettingIntervalDelegate Raise = (request, getAdditionalAmount) =>
    {
        var raiseDelta = getAdditionalAmount();
        var newBetAmount = request.CurrentBet.Amount + raiseDelta;

        var contributingPlayers = request.CurrentBet.ContributingPlayers.ToList();

        var currentContribution = contributingPlayers
            .SingleOrDefault(cp => cp.PlayerId == request.ParticipantInTurn.Id);

        if (currentContribution is not null)
            contributingPlayers.Remove(currentContribution);

        var playerAdditionalAmount =
            newBetAmount
            - (currentContribution?.Amount ?? 0);

        contributingPlayers.Add(new ContributingPlayer
        {
            PlayerId = request.ParticipantInTurn.Id,
            Amount = newBetAmount
        });

        return new BettingIntervalResponse
        {
            Description = $"Raises {playerAdditionalAmount:C0}",
            CurrentBet = new Bet
            {
                Amount = newBetAmount,
                InitiatingPlayerId = request.ParticipantInTurn.Id,
                CheckedPlayerIds = [],
                ContributingPlayers = contributingPlayers,
                TerminalPlayerIds = []
            },
            Pot = request.Pot + playerAdditionalAmount,
            ParticipantInTurn = request.ParticipantInTurn with
            {
                Stack = request.ParticipantInTurn.Stack - playerAdditionalAmount,
                Stake = request.ParticipantInTurn.Stake + playerAdditionalAmount
            },
            CloseBetting = false
        };
    };

    private static readonly BettingIntervalDelegate Fold = (request, _) =>
    {
        // if only one player remains, close betting.
        // subtracting one, because the betting player has not folded yet
        // but should be counting as folding.
        var closeBetting = (request.ActiveParticipants.NotFolded().Count() - 1) == 1;

        return new BettingIntervalResponse
        {
            Description = "Folds",
            CurrentBet = request.CurrentBet,
            Pot = request.Pot,
            ParticipantInTurn = request.ParticipantInTurn with { Folded = true },
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
