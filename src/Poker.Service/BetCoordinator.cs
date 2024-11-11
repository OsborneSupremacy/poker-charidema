namespace Poker.Service;

public class BetCoordinator : IPhaseService
{
    private readonly IBettingIntervalService _bettingIntervalService;

    private readonly WinnerEvaluator _winnerEvaluator;

    public BetCoordinator(IBettingIntervalService bettingIntervalService, WinnerEvaluator winnerEvaluator)
    {
        _bettingIntervalService =
            bettingIntervalService ?? throw new ArgumentNullException(nameof(bettingIntervalService));
        _winnerEvaluator = winnerEvaluator ?? throw new ArgumentNullException(nameof(winnerEvaluator));
    }

    public Task<PhaseResponse> ExecuteAsync(PhaseRequest request)
    {
        // are there any face-up cards? If so, determine who has best hand showing.
        // otherwise, player to left of the dealer bets








        PhaseResponse response = new()
        {
            Deck = request.Deck,
            CommunityCards = request.CommunityCards,
            Players = request.Game.Players,
            Winners = [],
            GameOver = false,
            Pot = request.Pot
        };

        return Task.FromResult(response);
    }
}
