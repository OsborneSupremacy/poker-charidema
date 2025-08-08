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

        var participantsOut = request
            .Game
            .Participants
            .ToDictionary(p => p.Id, p => p);

        var betResponse = BettingIntervalResponses.Empty with { Pot = request.Pot };

        while (!betResponse.CloseBetting)
        {
            var (bettingIntervalResponse, nextBettor) = await AdvanceBettingAsync(
                new BettingIntervalRequest
                {
                    CurrentBet = betResponse.CurrentBet,
                    Pot = betResponse.Pot,
                    ParticipantInTurn = currentBettor,
                    ActiveParticipants = participantsOut.Values.ToList()
                }
            );
            betResponse = bettingIntervalResponse;
            currentBettor = nextBettor;
            participantsOut[bettingIntervalResponse.ParticipantInTurn.Id] = bettingIntervalResponse.ParticipantInTurn;
        }

        var activePlayers = participantsOut.Values.NotFolded().ToList();
        var gameOver = activePlayers.Count == 1;

        return new()
        {
            Deck = request.Deck,
            CommunityCards = request.CommunityCards,
            Participants = participantsOut.Values.ToList(),
            Winners = gameOver ? activePlayers : [],
            GameOver = gameOver,
            Pot = betResponse.Pot
        };
    }

    private async Task<(BettingIntervalResponse bettingIntervalResponse, Participant nextBettor)>
        AdvanceBettingAsync(BettingIntervalRequest request)
    {
        BettingIntervalRequest betRequest = new()
        {
            CurrentBet = request.CurrentBet,
            Pot = request.Pot,
            ParticipantInTurn = request.ParticipantInTurn,
            ActiveParticipants = request.ActiveParticipants
        };

        var bettingIntervalResponse = await _bettingIntervalService.ExecuteAsync(betRequest);

        _userInterfaceService.WriteLine($"{request.ParticipantInTurn.Name} {bettingIntervalResponse.Description}.");

        var nextBettor = bettingIntervalResponse.CloseBetting switch
        {
            true => request.ParticipantInTurn,
            false => GetNextEligibleBettor(request.ActiveParticipants.NotFolded().ToList(), request.ParticipantInTurn, true)
        };

        return (bettingIntervalResponse, nextBettor);
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
            return leadPlayerResponse.LeadParticipants[0];
        }

        var leadPlayer = leadPlayerResponse.LeadParticipants[0];
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
    private static Participant GetFirstEligibleBettor(PhaseRequest request) =>
        GetNextEligibleBettor(request.Game.Participants, request.StartingParticipant, false);

    private static Participant GetNextEligibleBettor(
        IReadOnlyList<Participant> participants,
        Participant bettorIn,
        bool advanceToNext
        )
    {
        if (!participants.NotFolded().Any())
            throw new InvalidOperationException("All players folded");

        if(advanceToNext && participants.Count == 1)
            throw new InvalidOperationException("Only one player remains");

        var bettorOut = bettorIn;
        if(advanceToNext)
            bettorOut = participants.NextParticipant(bettorIn);

        while (bettorOut.Folded)
            bettorOut = participants.NextParticipant(bettorOut);
        return bettorOut;
    }
}
