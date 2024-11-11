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
        var currentBettor = request.StartingPlayer;

        // are there any face-up cards in player hands? If so, determine who has best hand showing.
        // otherwise, player to left of the dealer bets
        // we'll need a service to determine who has the best hand that's showing. "LeadPlayer"

        var anyFaceUpCards = request.Game.Players
            .SelectMany(p => p.CardsInPlay)
            .Any(c => c.CardOrientation == CardOrientations.FaceUp);

        if (anyFaceUpCards)
        {
            // we will need a service to identity
        }









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
