namespace Poker.Service;

public class BetService: IPhaseService
{
    public Task<PhaseResponse> ExecuteAsync(PhaseRequest request)
    {

        return Task.FromResult(new PhaseResponse
        {
            Deck = request.Deck,
            CommunityCards = request.CommunityCards,
            Players = request.Game.Players,
            Winners = new(),
            GameOver = false,
            Pot = request.Pot
        });
    }
}
