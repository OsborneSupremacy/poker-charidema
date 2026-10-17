namespace Poker.Service;

/// <inheritdoc />
internal class UserDiscardSelectionService : IUserDiscardSelectionService
{
    private readonly IUserInterfaceService _userInterfaceService;

    private readonly BestHandEvaluator _bestHandEvaluator;

    private readonly HandCollectionEvaluator _handCollectionEvaluator;

    private readonly HandEvaluator _handEvaluator;

    public UserDiscardSelectionService(
        IUserInterfaceService userInterfaceService,
        BestHandEvaluator bestHandEvaluator,
        HandCollectionEvaluator handCollectionEvaluator,
        HandEvaluator handEvaluator
        )
    {
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
        _bestHandEvaluator = bestHandEvaluator ?? throw new ArgumentNullException(nameof(bestHandEvaluator));
        _handCollectionEvaluator = handCollectionEvaluator ?? throw new ArgumentNullException(nameof(handCollectionEvaluator));
        _handEvaluator = handEvaluator ?? throw new ArgumentNullException(nameof(handEvaluator));
    }

    public Task<IReadOnlyList<Card>> SelectAsync(DiscardSelectionRequest request)
    {
        var hand = request.Participant.CardsInPlay.ToCards();

        // evaluated so the cards are listed the same way as when the hand is rendered
        var participantHand = _bestHandEvaluator(
            new BestHandRequest
            {
                Participant = request.Participant,
                RemainingCardCount = 0,
                HandCollectionEvaluator = _handCollectionEvaluator,
                HandEvaluator = _handEvaluator
            }
        ).ToPlayerHand();

        while (true)
        {
            var discards = _userInterfaceService
                .PromptForCards(GetPrompt(request.Phase), participantHand)
                .ToList();

            var maximum = request.Phase.GetDrawMaximum(hand.Except(discards));

            if (discards.Count <= maximum)
                return Task.FromResult<IReadOnlyList<Card>>(discards);

            _userInterfaceService.WriteLine($"You can't discard {discards.Count} cards with the cards you're keeping. The most you can discard is {maximum}.");
        }
    }

    private static string GetPrompt(Phase phase)
    {
        var overrides = phase.CardsToDrawMaximumOverrides
            .Select(o => $", or {o.Maximum} if you keep {o.Rank.Name.WithIndefiniteArticle()}");

        return $"Choose cards to discard (up to {phase.CardsToDrawMaximum}{string.Concat(overrides)}):";
    }
}
