namespace Poker.Service;

/// <inheritdoc />
internal class PhaseCoordinator : IPhaseCoordinator
{
    private readonly IPhaseService _phaseService;

    private readonly IUserInterfaceService _userInterfaceService;

    private readonly BestHandEvaluator _bestHandEvaluator;

    private readonly HandCollectionEvaluator _handCollectionEvaluator;

    private readonly HandEvaluator _handEvaluator;

    public PhaseCoordinator(IPhaseService phaseService, IUserInterfaceService userInterfaceService, BestHandEvaluator bestHandEvaluator, HandCollectionEvaluator handCollectionEvaluator, HandEvaluator handEvaluator)
    {
        _phaseService = phaseService;
        _userInterfaceService = userInterfaceService;
        _bestHandEvaluator = bestHandEvaluator;
        _handCollectionEvaluator = handCollectionEvaluator;
        _handEvaluator = handEvaluator;
    }

    public async Task<CoordinatePhaseResponse> ExecuteAsync(
        CoordinatePhaseRequest request
        )
    {
        var startingPlayer = request
            .Participants.ToList()
            .NextParticipant
            (
                request.Button
            );

        var phaseResponse = await _phaseService
            .ExecuteAsync(new PhaseRequest
            {
                Phase = request.Phase,
                Deck = request.Deck,
                CommunityCards = [],
                StartingParticipant = startingPlayer,
                Pot = request.Pot,
                GameOver = request.GameOver,
                Participants = request.Participants,
                Ante = request.Ante
            });

        if (phaseResponse.GameOver)
            return new CoordinatePhaseResponse
            {
                Deck = phaseResponse.Deck,
                CommunityCards = phaseResponse.CommunityCards,
                Participants = phaseResponse.Participants,
                Winners = phaseResponse.Winners,
                GameOver = phaseResponse.GameOver,
                Pot = phaseResponse.Pot
            };

        _userInterfaceService
            .WriteLine()
            .WriteLine($"Pot: {phaseResponse.Pot:C0}");

        RenderPlayerCards(
            phaseResponse.Participants.HumanParticipant(),
            request.Variant.GetRemainingCardCount(request.Phase.Number)
        );

        return new CoordinatePhaseResponse
        {
            Deck = phaseResponse.Deck,
            CommunityCards = phaseResponse.CommunityCards,
            Participants = phaseResponse.Participants,
            Winners = phaseResponse.Winners,
            GameOver = phaseResponse.GameOver,
            Pot = phaseResponse.Pot
        };
    }

    private void RenderPlayerCards(Participant player, int remainingCardCount)
    {
        if (!player.CardsInPlay.Any())
            return;

        var bestHand = _bestHandEvaluator
        (
            new BestHandRequest
            {
                Participant = player,
                RemainingCardCount = remainingCardCount,
                HandCollectionEvaluator = _handCollectionEvaluator,
                HandEvaluator = _handEvaluator
            }
        );

        var label = !player.Automaton ? "Your" : $"{player.Name}'s";

        _userInterfaceService
            .WriteLine()
            .RenderCards($"{label} Cards", bestHand.ToPlayerHand());

        _userInterfaceService.WriteLine($"{label} best hand is: {bestHand.Hand.Name}");
    }
}
