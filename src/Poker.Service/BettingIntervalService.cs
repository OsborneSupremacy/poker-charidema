using System.Text;

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
            ParticipantInTurnId = request.ParticipantInTurn.Id,
            ActiveParticipants = request.ActiveParticipants.NotFolded().ToList(),
        };

        var optionsResponse = await _bettingIntervalOptionsService
            .ExecuteAsync(optionsRequest);

        // pick random option
        var option = _randomService
            .PickFromReadOnlyList(optionsResponse.AvailableBettingIntervalActions);

        var optionDelegate = BettingIntervalDelegates[option] ?? Fold;

        var maxBet = optionsResponse.MaximumBet;

#if DEBUG
        Console.WriteLine($"  - Current Bet {request.CurrentBet.Amount:C0}.");
        Console.WriteLine($"  - Maximum Bet {maxBet:C0}.");
#endif
        return optionDelegate(
            request,
            () => _randomService.GetAmount(1, maxBet)
        );
    }

    /// <summary>
    /// <param name="getAdditionalAmount">Gets the amount the player is adding to the current bet.</param>
    /// </summary>
    private delegate BettingIntervalResponse BettingIntervalDelegate(
        BettingIntervalRequest request,
        Func<int> getAdditionalAmount
        );

    private static readonly BettingIntervalDelegate Bet = (request, getAdditionalAmount) =>
    {
        var betAmount = getAdditionalAmount();

        var contributions = request.ActiveParticipants.ToDictionary(p => p.Id, _ => 0);
        contributions[request.ParticipantInTurn.Id] = betAmount;

        var newStack = request.ParticipantInTurn.Stack - betAmount;
        var newStake = request.ParticipantInTurn.Stake + betAmount;
        var newPot = request.Pot + betAmount;

        StringBuilder d = new();
        d.Append($"Bets {betAmount:C0}");

#if DEBUG
        d.AppendLine();
        d.AppendLine($"  - New Stake: {newStake:C0}");
        d.AppendLine($"  - New Stack: {newStack:C0}");
        d.AppendLine($"  - New Pot: {newPot:C0}");
        d.AppendLine();
#endif

        return new BettingIntervalResponse
        {
            Description = d.ToString(),
            CurrentBet = new Bet
            {
                Amount = betAmount,
                InitiatingPlayerId = request.ParticipantInTurn.Id,
                CheckedPlayerIds = [],
                PlayerContributions = contributions,
                TerminalPlayerIds = []
            },
            Pot = newPot,
            ParticipantInTurn = request.ParticipantInTurn with
            {
                Stack = newStack,
                Stake = newStake
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
        var contributions = request.CurrentBet.PlayerContributions.ToDictionary();
        var currentContribution = contributions[request.ParticipantInTurn.Id];

        var additionalAmount = request.CurrentBet.Amount - currentContribution;

#if DEBUG
        Console.WriteLine($"  - {request.ParticipantInTurn.Name} needs to contribute {additionalAmount:C0} to call.");
#endif

        var allPlayersCalled = request.ActiveParticipants.NotFolded()
            .All(p => contributions[p.Id] >= request.CurrentBet.Amount);

        var newStack = request.ParticipantInTurn.Stack - additionalAmount;
        var newStake = request.ParticipantInTurn.Stake + additionalAmount;
        var newPot = request.Pot + additionalAmount;

        StringBuilder d = new();
        d.Append($"Calls with {additionalAmount:C0}");

#if DEBUG
        d.AppendLine();
        d.AppendLine($"  - New Stake: {newStake:C0}");
        d.AppendLine($"  - New Stack: {newStack:C0}");
        d.AppendLine($"  - New Pot: {newPot:C0}");
        d.AppendLine();
#endif

        return new BettingIntervalResponse
        {
            Description = d.ToString(),
            CurrentBet = request.CurrentBet with
            {
                PlayerContributions = contributions,
                TerminalPlayerIds = request.CurrentBet.TerminalPlayerIds
            },
            Pot = newPot,
            ParticipantInTurn = request.ParticipantInTurn with
            {
                Stack = newStack,
                Stake = newStake
            },
            CloseBetting = allPlayersCalled
        };
    };

    private static readonly BettingIntervalDelegate Raise = (request, getAdditionalAmount) =>
    {
        var raiseDelta = getAdditionalAmount();
        var newBetAmount = request.CurrentBet.Amount + raiseDelta;

        var contributions = request.CurrentBet.PlayerContributions.ToDictionary();

        var currentContribution = contributions[request.ParticipantInTurn.Id];
        var playerAdditionalAmount = newBetAmount - currentContribution;
        contributions[request.ParticipantInTurn.Id] = newBetAmount;

        var newStack = request.ParticipantInTurn.Stack - playerAdditionalAmount;
        var newStake = request.ParticipantInTurn.Stake + playerAdditionalAmount;
        var newPot = request.Pot + playerAdditionalAmount;

        StringBuilder d = new();
        d.Append($"Raises {raiseDelta:C0} to {newBetAmount:C0}");

#if DEBUG
        d.AppendLine();
        d.AppendLine($"  - New Stake: {newStake:C0}");
        d.AppendLine($"  - New Stack: {newStack:C0}");
        d.AppendLine($"  - New Pot: {newPot:C0}");
        d.AppendLine();
#endif

        return new BettingIntervalResponse
        {
            Description = d.ToString(),
            CurrentBet = new Bet
            {
                Amount = newBetAmount,
                InitiatingPlayerId = request.ParticipantInTurn.Id,
                CheckedPlayerIds = [],
                PlayerContributions = contributions,
                TerminalPlayerIds = []
            },
            Pot = newPot,
            ParticipantInTurn = request.ParticipantInTurn with
            {
                Stack = newStack,
                Stake = newStake
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
