namespace Poker.Service;

/// <inheritdoc />
internal class AutomatonDiscardSelectionService : IAutomatonDiscardSelectionService
{
    private readonly BestHandEvaluator _bestHandEvaluator;

    private readonly HandCollectionEvaluator _handCollectionEvaluator;

    private readonly HandEvaluator _handEvaluator;

    private readonly DiscardStrategy _discardStrategy;

    public AutomatonDiscardSelectionService(
        BestHandEvaluator bestHandEvaluator,
        HandCollectionEvaluator handCollectionEvaluator,
        HandEvaluator handEvaluator,
        DiscardStrategy discardStrategy
        )
    {
        _bestHandEvaluator = bestHandEvaluator ?? throw new ArgumentNullException(nameof(bestHandEvaluator));
        _handCollectionEvaluator = handCollectionEvaluator ?? throw new ArgumentNullException(nameof(handCollectionEvaluator));
        _handEvaluator = handEvaluator ?? throw new ArgumentNullException(nameof(handEvaluator));
        _discardStrategy = discardStrategy ?? throw new ArgumentNullException(nameof(discardStrategy));
    }

    public Task<IReadOnlyList<Card>> SelectAsync(DiscardSelectionRequest request)
    {
        var bestHand = _bestHandEvaluator(
            new BestHandRequest
            {
                Participant = request.Participant,
                RemainingCardCount = 0,
                HandCollectionEvaluator = _handCollectionEvaluator,
                HandEvaluator = _handEvaluator
            }
        );

        return Task.FromResult(
            _discardStrategy(
                new DiscardStrategyRequest
                {
                    ParticipantHand = bestHand.ToPlayerHand(),
                    Phase = request.Phase
                }
            )
        );
    }
}
