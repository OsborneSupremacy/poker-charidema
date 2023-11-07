namespace Poker.Service;

public class BettingIntervalService: IBettingIntervalService
{
    private readonly IBettingIntervalOptionsService _bettingIntervalOptionsService;

    public BettingIntervalService(IBettingIntervalOptionsService bettingIntervalOptionsService)
    {
        _bettingIntervalOptionsService = bettingIntervalOptionsService ??
                                         throw new ArgumentNullException(nameof(bettingIntervalOptionsService));
    }

    public async Task<BettingIntervalResponse> ExecuteAsync(BettingIntervalRequest request)
    {
        var currentBet = Bets.Empty;
        
        BettingIntervalOptionsRequest optionsRequest = new()
        {
            CurrentBet = currentBet,
            ActivePlayers = request.ActivePlayers
        };
        
        var options = await _bettingIntervalOptionsService
            .ExecuteAsync(optionsRequest);
        
        // choose an option
        
        // execute the option
        
        return new BettingIntervalResponse
        {
            Bets = new(),
            Pot = 0,
            PlayerInTurn = request.PlayerInTurn
        };
    }
}
