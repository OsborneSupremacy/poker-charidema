namespace Poker.Service;

/// <inheritdoc />
internal class DrawCoordinator : IPhaseService
{
    private readonly IUserInterfaceService _userInterfaceService;

    private readonly IUserDiscardSelectionService _userDiscardSelectionService;

    private readonly IAutomatonDiscardSelectionService _automatonDiscardSelectionService;

    private readonly IDealerService _dealerService;

    private readonly Drawer _drawer;

    public DrawCoordinator(
        IUserInterfaceService userInterfaceService,
        IUserDiscardSelectionService userDiscardSelectionService,
        IAutomatonDiscardSelectionService automatonDiscardSelectionService,
        IDealerService dealerService,
        Drawer drawer
        )
    {
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
        _userDiscardSelectionService = userDiscardSelectionService ?? throw new ArgumentNullException(nameof(userDiscardSelectionService));
        _automatonDiscardSelectionService = automatonDiscardSelectionService ?? throw new ArgumentNullException(nameof(automatonDiscardSelectionService));
        _dealerService = dealerService ?? throw new ArgumentNullException(nameof(dealerService));
        _drawer = drawer ?? throw new ArgumentNullException(nameof(drawer));
    }

    public async Task<PhaseResponse> ExecuteAsync(PhaseRequest request)
    {
        if (request.GameOver)
            return request.ToGameOverResponse();

        _userInterfaceService.WriteHeading(HeadingLevel.Five, $"{request.Phase.Name}");

        var participantsOut = request.Participants.ToList();
        var deckOut = request.Deck;
        var discardsOut = request.Discards;

        var drawingOrder = request.Participants
            .InTurnOrderFrom(request.StartingParticipant)
            .NotFolded()
            .Select(p => p.Id)
            .ToList();

        foreach (var participantId in drawingOrder)
        {
            var index = participantsOut.FindIndex(p => p.Id == participantId);
            var participant = participantsOut[index];

            var cardsToDiscard = await GetDiscardSelectionService(participant)
                .SelectAsync(new DiscardSelectionRequest
                {
                    Participant = participant,
                    Phase = request.Phase
                });

            ValidateDrawMaximum(request.Phase, participant, cardsToDiscard);

            if (deckOut.Cards.Count < cardsToDiscard.Count)
            {
                deckOut = await RefillDeckAsync(deckOut, discardsOut);
                discardsOut = [];
            }

            var drawResponse = _drawer(new DrawRequest
            {
                Participant = participant,
                CardsToDiscard = cardsToDiscard,
                Deck = deckOut,
                Discards = discardsOut,
                CardOrientation = request.Phase.CardOrientation
            });

            _userInterfaceService.WriteLine(
                drawResponse.CardsDrawn.Count == 0
                    ? $"{participant.Name} stands pat."
                    : $"{participant.Name} draws {drawResponse.CardsDrawn.Count}."
            );

            participantsOut[index] = drawResponse.Participant;
            deckOut = drawResponse.Deck;
            discardsOut = drawResponse.Discards;
        }

        return new PhaseResponse
        {
            Deck = deckOut,
            CommunityCards = request.CommunityCards,
            Discards = discardsOut,
            Participants = participantsOut,
            Winners = [],
            GameOver = false,
            Pot = request.Pot
        };
    }

    private IDiscardSelectionService GetDiscardSelectionService(Participant participant) =>
        participant.Automaton switch
        {
            true => _automatonDiscardSelectionService,
            false => _userDiscardSelectionService
        };

    private static void ValidateDrawMaximum(Phase phase, Participant participant, IReadOnlyList<Card> cardsToDiscard)
    {
        var keptCards = participant.CardsInPlay.ToCards().Except(cardsToDiscard);
        var maximum = phase.GetDrawMaximum(keptCards);

        if (cardsToDiscard.Count > maximum)
            throw new InvalidOperationException(
                $"{participant.Name} cannot draw {cardsToDiscard.Count} cards; the maximum is {maximum}.");
    }

    /// <summary>
    /// Shuffles the discard pile and places it under the cards remaining in the deck.
    /// The participant about to draw hasn't discarded yet, so their own discards
    /// are never dealt back to them.
    /// </summary>
    private async Task<Deck> RefillDeckAsync(Deck deck, IReadOnlyList<CardInPlay> discards)
    {
        _userInterfaceService.WriteLine("The deck is running low. The discards are shuffled back into the deck.");

        var shuffledDiscards = await _dealerService.ShuffleAsync(deck with { Cards = discards.ToCards() });

        return deck with { Cards = deck.Cards.Concat(shuffledDiscards.Cards).ToList() };
    }
}
