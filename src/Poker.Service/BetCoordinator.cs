namespace Poker.Service;

/// <inheritdoc />
internal class BetCoordinator : IPhaseService
{
    private readonly IUserInterfaceService _userInterfaceService;

    private readonly IBettingIntervalService _bettingIntervalService;

    private readonly ILeadPlayerService _leadPlayerService;

    public BetCoordinator(
        IUserInterfaceService userInterfaceService,
        IBettingIntervalService bettingIntervalService,
        ILeadPlayerService leadPlayerService
        )
    {
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
        _bettingIntervalService =
            bettingIntervalService ?? throw new ArgumentNullException(nameof(bettingIntervalService));
        _leadPlayerService = leadPlayerService ?? throw new ArgumentNullException(nameof(leadPlayerService));
    }

    public async Task<PhaseResponse> ExecuteAsync(PhaseRequest request)
    {
        if (request.GameOver)
            return request.ToGameOverResponse();

        _userInterfaceService.WriteHeading(HeadingLevel.Five, $"{request.Phase.Name}");

        var currentBettor = await GetCurrentBettorAsync(request);
        _userInterfaceService.WriteLine($"{currentBettor.Name} starts the bet.");

        var players = request
            .Game
            .Participants
            .ToDictionary(p => p.Id, p => p);

        var betResponse = BettingIntervalResponses.Empty with { Pot = request.Pot };

        while (!betResponse.CloseBetting)
            await AdvanceBettingAsync();

        var activePlayers = players.Values.NotFolded().ToList();
        var gameOver = activePlayers.Count == 1;

        return new()
        {
            Deck = request.Deck,
            CommunityCards = request.CommunityCards,
            Participants = players.Values.ToList(),
            Winners = gameOver ? activePlayers : [],
            GameOver = gameOver,
            Pot = betResponse.Pot
        };

        async Task AdvanceBettingAsync()
        {
            BettingIntervalRequest betRequest = new()
            {
                CurrentBet = betResponse.CurrentBet,
                Pot = betResponse.Pot,
                ParticipantInTurn = players[currentBettor.Id],
                ActiveParticipants = players.Values.NotFolded().ToList()
            };

            betResponse = await _bettingIntervalService.ExecuteAsync(betRequest);

            _userInterfaceService.WriteLine($"{currentBettor.Name} {betResponse.Description}.");

            players[currentBettor.Id] = betResponse.ParticipantInTurn;

            currentBettor =
                betResponse.CloseBetting ? currentBettor
                    : request.Game.Participants.NotFolded().ToList().NextParticipant(currentBettor);
        }
    }

    private async Task<Participant> GetCurrentBettorAsync(PhaseRequest request)
    {
        var anyFaceUpCards = request.Game.Participants
            .NotFolded()
            .SelectMany(p => p.CardsInPlay)
            .FaceUp()
            .Any();

        if (!anyFaceUpCards)
            return GetFirstEligibleBettor(request);

        var leadPlayerResponse = await _leadPlayerService.ExecuteAsync(
            new EvaluateLeadParticipantRequest
            {
                CommunityCards = request.CommunityCards,
                Participants = request.Game.Participants
            }
        );

        if (leadPlayerResponse.LeadParticipants.Count > 1)
        {
            _userInterfaceService.WriteLine($"Multiple players have the best hand showing, with {leadPlayerResponse.LeadingHand.Name}.");
            _userInterfaceService.WriteLine("The tie goes to the player closest to the dealer.");
            return leadPlayerResponse.LeadParticipants.First();
        }

        var leadPlayer = leadPlayerResponse.LeadParticipants.First();
        _userInterfaceService.WriteLine($"{leadPlayer.Name} has the best hand showing with {leadPlayerResponse.LeadingHand.Name}.");
        return leadPlayer;
    }

    /// <summary>
    /// When there are no face up cards, the player who bets first is the starting player,
    /// or the player closest to him, who has not folded.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException">If all players have folded, this method should not have been invoked.</exception>
    private static Participant GetFirstEligibleBettor(PhaseRequest request)
    {
        // if we don't do this check here, we risk an infinite loop
        if (!request.Game.Participants.NotFolded().Any())
            throw new InvalidOperationException("All players folded");
        var currentBettor = request.StartingParticipant;
        while (currentBettor.Folded)
            currentBettor = request.Game.Participants.NextParticipant(currentBettor);
        return currentBettor;
    }
}
