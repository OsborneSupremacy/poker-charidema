using System.Text;

namespace Poker.Service;

/// <inheritdoc />
internal class BettingIntervalService : IBettingIntervalService
{
    private readonly IBettingIntervalOptionsService _bettingIntervalOptionsService;

    private readonly IUserBettingIntervalActionSelectionService _userActionSelectionService;

    private readonly IAutomatonBettingIntervalActionSelectionService _automatonActionSelectionService;

    public BettingIntervalService(
        IBettingIntervalOptionsService bettingIntervalOptionsService,
        IUserBettingIntervalActionSelectionService userActionSelectionService,
        IAutomatonBettingIntervalActionSelectionService automatonActionSelectionService
        )
    {
        _bettingIntervalOptionsService = bettingIntervalOptionsService ??
                                         throw new ArgumentNullException(nameof(bettingIntervalOptionsService));
        _userActionSelectionService = userActionSelectionService ??
                                      throw new ArgumentNullException(nameof(userActionSelectionService));
        _automatonActionSelectionService = automatonActionSelectionService ??
                                           throw new ArgumentNullException(nameof(automatonActionSelectionService));
    }

    public async Task<BettingIntervalResponse> ExecuteAsync(BettingIntervalRequest request)
    {
        BettingIntervalOptionsRequest optionsRequest = new()
        {
            CurrentBet = request.CurrentBet,
            ParticipantInTurnId = request.ParticipantInTurn.Id,
            ActiveParticipants = request.ActiveParticipants.NotFolded().ToList(),
            APlayerIsAllIn = request.APlayerIsAllIn
        };

        var optionsResponse = await _bettingIntervalOptionsService
            .ExecuteAsync(optionsRequest);

        var selection = await GetActionSelectionService(request.ParticipantInTurn)
            .SelectAsync(new BettingIntervalActionSelectionRequest
            {
                ParticipantInTurn = request.ParticipantInTurn,
                CurrentBet = request.CurrentBet,
                Pot = request.Pot,
                Options = optionsResponse
            });

        var optionDelegate = BettingIntervalDelegates[selection.BettingIntervalActionType] ?? Fold;

#if DEBUG
        Console.WriteLine($"  - Current Bet {request.CurrentBet.Amount:C0}.");
        Console.WriteLine($"  - Maximum Bet {optionsResponse.MaximumBet:C0}.");
#endif
        return optionDelegate(request, selection.Amount);
    }

    private IBettingIntervalActionSelectionService GetActionSelectionService(Participant participant) =>
        participant.Automaton switch
        {
            true => _automatonActionSelectionService,
            false => _userActionSelectionService
        };

    /// <summary>
    /// <param name="additionalAmount">The amount the player is adding to the current bet.</param>
    /// </summary>
    private delegate BettingIntervalResponse BettingIntervalDelegate(
        BettingIntervalRequest request,
        int additionalAmount
        );

    private static readonly BettingIntervalDelegate Bet = (request, betAmount) =>
    {
        if(request.APlayerIsAllIn)
            throw new InvalidOperationException("Cannot bet while another participant is all-in.");

        var contributions = request.ActiveParticipants.ToDictionary(p => p.Id, _ => 0);
        contributions[request.ParticipantInTurn.Id] = betAmount;

        var newStack = request.ParticipantInTurn.Stack - betAmount;
        var newStake = request.ParticipantInTurn.Stake + betAmount;
        var newPot = request.Pot + betAmount;

        var allIn = newStack <= 0;

        StringBuilder d = new();
        if (allIn)
            d.Append($"Goes all-in with {betAmount:C0}");
        else
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
                PlayerContributions = contributions
            },
            Pot = newPot,
            ParticipantInTurn = request.ParticipantInTurn with
            {
                Stack = newStack,
                Stake = newStake
            },
            AllIn = allIn,
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
            AllIn = request.APlayerIsAllIn,
            CloseBetting = closeBetting
        };
    };

    private static readonly BettingIntervalDelegate Call = (request, _) =>
    {
        var contributions = request.CurrentBet.PlayerContributions.ToDictionary();
        var currentContribution = contributions[request.ParticipantInTurn.Id];

        // a player who can't afford the full call goes all-in with what they have left
        var additionalAmount = Math.Min(
            request.CurrentBet.Amount - currentContribution,
            request.ParticipantInTurn.Stack
        );

#if DEBUG
        Console.WriteLine($"  - {request.ParticipantInTurn.Name} needs to contribute {request.CurrentBet.Amount - currentContribution:C0} to call.");
#endif
        contributions[request.ParticipantInTurn.Id] = currentContribution + additionalAmount;

        var newStack = request.ParticipantInTurn.Stack - additionalAmount;
        var newStake = request.ParticipantInTurn.Stake + additionalAmount;
        var newPot = request.Pot + additionalAmount;

        var participantInTurnOut = request.ParticipantInTurn with
        {
            Stack = newStack,
            Stake = newStake
        };

        var currentBetOut = request.CurrentBet with
        {
            PlayerContributions = contributions
        };

        var allPlayersCalled = request.ActiveParticipants.NotFolded()
            .Select(p => p.Id == participantInTurnOut.Id ? participantInTurnOut : p)
            .All(p => HasCalledOrIsAllIn(currentBetOut, p));

        var allIn = newStack <= 0;

        StringBuilder d = new();
        if (allIn)
            d.Append($"Goes all-in with {additionalAmount:C0}");
        else
            d.Append($"Calls with {additionalAmount:C0} (for a total stake of {newStake:C0})");

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
            CurrentBet = currentBetOut,
            Pot = newPot,
            ParticipantInTurn = participantInTurnOut,
            AllIn = request.APlayerIsAllIn || allIn,
            CloseBetting = allPlayersCalled
        };
    };

    private static readonly BettingIntervalDelegate Raise = (request, raiseAmount) =>
    {
        var newBetAmount = request.CurrentBet.Amount + raiseAmount; // newBetAmount is also the player's new contribution

        var contributions = request.CurrentBet.PlayerContributions.ToDictionary();
        var currentContribution = contributions[request.ParticipantInTurn.Id];

        // the player pays what they need to call, plus the raise
        var additionalAmount = newBetAmount - currentContribution;
        contributions[request.ParticipantInTurn.Id] = newBetAmount;

        var newStack = request.ParticipantInTurn.Stack - additionalAmount;
        var newStake = request.ParticipantInTurn.Stake + additionalAmount;
        var newPot = request.Pot + additionalAmount;

        var allIn = newStack <= 0;

        StringBuilder d = new();

        if (allIn)
            d.Append($"Goes all-in with {additionalAmount:C0}");
        else
            d.Append($"Raises {raiseAmount:C0} to {newBetAmount:C0}");

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
                PlayerContributions = contributions
            },
            Pot = newPot,
            ParticipantInTurn = request.ParticipantInTurn with
            {
                Stack = newStack,
                Stake = newStake
            },
            AllIn = request.APlayerIsAllIn || allIn,
            CloseBetting = false
        };
    };

    private static readonly BettingIntervalDelegate Fold = (request, _) =>
    {
        var remainingPlayers = request.ActiveParticipants
            .Where(p => p.Id != request.ParticipantInTurn.Id)
            .NotFolded()
            .ToList();

        var onlyOnePlayerRemains = remainingPlayers.Count <= 1;

        var allRemainingPlayersCalled = request.CurrentBet.Amount > 0
            && remainingPlayers.All(p => HasCalledOrIsAllIn(request.CurrentBet, p));

        var allRemainingPlayersChecked = request.CurrentBet.Amount == 0
            && remainingPlayers.All(p => request.CurrentBet.CheckedPlayerIds.Contains(p.Id));

        var closeBetting = onlyOnePlayerRemains || allRemainingPlayersCalled || allRemainingPlayersChecked;

        return new BettingIntervalResponse
        {
            Description = "Folds",
            CurrentBet = request.CurrentBet,
            Pot = request.Pot,
            ParticipantInTurn = request.ParticipantInTurn with { Folded = true },
            AllIn = request.APlayerIsAllIn,
            CloseBetting = closeBetting
        };
    };

    /// <summary>
    /// A player who has gone all-in for less than the current bet can't contribute any more,
    /// so they don't hold up the betting.
    /// </summary>
    private static bool HasCalledOrIsAllIn(Bet bet, Participant participant) =>
        bet.PlayerContributions.GetValueOrDefault(participant.Id) >= bet.Amount
        || participant.Stack <= 0;

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
