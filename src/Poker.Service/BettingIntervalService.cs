namespace Poker.Service;

public class BettingIntervalService : IBettingIntervalService
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
        var currentBet = Bets.Empty;

        BettingIntervalOptionsRequest optionsRequest = new()
        {
            CurrentBet = currentBet,
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
            CurrentBet = new Bet
            {
                Amount = betAmount,
                InitiatingPlayerId = request.PlayerInTurn.Id,
                CheckedPlayerIds = [],
                ContributingPlayers =
                [
                    new ContributingPlayer { PlayerId = request.PlayerInTurn.Id, Amount = betAmount }
                ]
            },
            Pot = request.Pot + betAmount,
            PlayerInTurn = request.PlayerInTurn with
            {
                Stack = request.PlayerInTurn.Stack - betAmount,
                Stake = request.PlayerInTurn.Stake + betAmount
            }
        };
    };

    private static readonly BettingIntervalDelegate Check = (request, _) =>
    {
        var checkedPlayerIds = request.CurrentBet.CheckedPlayerIds;
        checkedPlayerIds.Add(request.PlayerInTurn.Id);

        return new BettingIntervalResponse
        {
            CurrentBet = request.CurrentBet with
            {
                CheckedPlayerIds = checkedPlayerIds
            },
            Pot = request.Pot,
            PlayerInTurn = request.PlayerInTurn
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

        return new BettingIntervalResponse
        {
            CurrentBet = request.CurrentBet with
            {
                ContributingPlayers = contributingPlayers
            },
            Pot = request.Pot + additionalAmount,
            PlayerInTurn = request.PlayerInTurn with
            {
                Stack = request.PlayerInTurn.Stack - additionalAmount,
                Stake = request.PlayerInTurn.Stake + additionalAmount
            }
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
            CurrentBet = new Bet
            {
                Amount = newBetAmount,
                InitiatingPlayerId = request.PlayerInTurn.Id,
                CheckedPlayerIds = [],
                ContributingPlayers = contributingPlayers
            },
            Pot = request.Pot + playerAdditionalAmount,
            PlayerInTurn = request.PlayerInTurn with
            {
                Stack = request.PlayerInTurn.Stack - playerAdditionalAmount,
                Stake = request.PlayerInTurn.Stake + playerAdditionalAmount
            }
        };
    };

    private static readonly BettingIntervalDelegate Fold = (request, _) =>
        new BettingIntervalResponse
        {
            CurrentBet = request.CurrentBet,
            Pot = request.Pot,
            PlayerInTurn = request.PlayerInTurn with { Folded = true }
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
