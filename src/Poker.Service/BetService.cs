namespace Poker.Service;

public class BetService: IBetService
{
    public BetResponse Execute(BetRequest request)
    {
        var lastBet = request
            .Bets
            .Where(b => b.Type != BetType.Empty)
            .LastOrDefault() ?? new Bet
        {
            Amount = 0,
            Type = BetType.Empty,
            PlayerId = Players.Empty.Id
        };
        
        List<BetType> availableBetTypes = new();
        
        if (lastBet.Type == BetType.Empty)
        {
            availableBetTypes.Add(BetType.Check);
            availableBetTypes.Add(BetType.Raise);
        }
        else if (lastBet.Type == BetType.Check)
        {
            availableBetTypes.Add(BetType.Check);
            availableBetTypes.Add(BetType.Raise);
        }
        else if (lastBet.Type == BetType.Call)
        {
            availableBetTypes.Add(BetType.Check);
            availableBetTypes.Add(BetType.Raise);
        }
        else if (lastBet.Type == BetType.Raise)
        {
            availableBetTypes.Add(BetType.Call);
            availableBetTypes.Add(BetType.Raise);
            availableBetTypes.Add(BetType.Fold);
        }
        else if (lastBet.Type == BetType.Fold)
        {
            availableBetTypes.Add(BetType.Fold);
        }
        
        
        
        
        
        return new Poker.Domain.Messaging.BetResponse
        {
            Bets = new(),
            Pot = 0,
            PlayerInTurn = request.PlayerInTurn
        };
    }
}
