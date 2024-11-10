namespace Poker.Service;

public class BetCoordinator : IBetCoordinator
{
    private readonly IRandomFactory _randomFactory;

    public Task<PhaseResponse> ExecuteAsync(PhaseRequest request)
    {
        // get player to the left of the dealer
        var playerInTurn = request.StartingPlayer;

        // if player is automaton, whether it bets will be random, initially.
        bool playerWillBet = _randomFactory.Create().Next(0, 2) == 1;





        throw new NotImplementedException();
    }
}
