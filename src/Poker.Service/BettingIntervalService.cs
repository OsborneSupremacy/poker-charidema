namespace Poker.Service;

public class BettingIntervalService: IBettingIntervalService
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
            () => _randomService.GetAmount(request.CurrentBet.Amount, maxBet)
        );
    }
    
    private delegate BettingIntervalResponse BettingIntervalDelegate(
        BettingIntervalRequest request,
        Func<int> getBetAmount
        );

    private static readonly BettingIntervalDelegate Bet = (request, getBetAmount) =>
    {
        var betAmount = getBetAmount();
        
        return new BettingIntervalResponse
        {
            CurrentBet = new Bet
            {
                Amount = betAmount,
                InitiatingPlayerId = request.PlayerInTurn.Id,
                ContributedPlayers = new()
                {
                    new ContributedPlayer
                    {
                        PlayerId = request.PlayerInTurn.Id,
                        Amount = betAmount
                    }
                }
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
        return new BettingIntervalResponse
        {
            CurrentBet = request.CurrentBet,
            Pot = request.Pot, 
            PlayerInTurn = request.PlayerInTurn
        };
    };

    private static readonly BettingIntervalDelegate Call = (request, _) =>
    {
        return new BettingIntervalResponse
        {
            CurrentBet = request.CurrentBet,
            Pot = request.Pot + request.CurrentBet.Amount,
            PlayerInTurn = request.PlayerInTurn with
            {
                Stack = request.PlayerInTurn.Stack - request.CurrentBet.Amount,
                Stake = request.PlayerInTurn.Stake + request.CurrentBet.Amount
            }
        };
    };
    
    private static readonly BettingIntervalDelegate Raise = (request, _) =>
    {
        return new BettingIntervalResponse
        {
            CurrentBet = request.CurrentBet,
            Pot = request.Pot,
            PlayerInTurn = request.PlayerInTurn
        };
    };

    private static readonly BettingIntervalDelegate Fold = (request, _) =>
    {
        return new BettingIntervalResponse
        {
            CurrentBet = request.CurrentBet,
            Pot = request.Pot,
            PlayerInTurn = request.PlayerInTurn with { Folded = true }
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
