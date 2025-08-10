namespace Poker.Service;

/// <inheritdoc />
internal class RoundRobinMoveService : IPhaseService
{
    private readonly IUserInterfaceService _userInterfaceService;

    private readonly IMoveServiceFactory _moveServiceFactory;

    public RoundRobinMoveService(
        IUserInterfaceService userInterfaceService,
        IMoveServiceFactory moveServiceFactory)
    {
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
        _moveServiceFactory = moveServiceFactory ?? throw new ArgumentNullException(nameof(moveServiceFactory));
    }

    public async Task<PhaseResponse> ExecuteAsync(PhaseRequest request)
    {
        if (request.GameOver)
            return request.ToGameOverResponse();

        _userInterfaceService.WriteHeading(
            HeadingLevel.Five,
            $"{request.Phase.Name}"
        );

        var playersOut = new List<Participant>();

        var ccOut = request.CommunityCards;
        var deckOut = request.Deck;
        var potOut = request.Pot;

        var playerInTurn = request.StartingParticipant;

        while (playersOut.Count < request.Participants.Count)
        {
            MoveRequest moveRequest = new()
            {
                ParticipantInTurn = playerInTurn,
                PhaseRequest = request,
                Pot = potOut
            };

            var moveResponse = await _moveServiceFactory
                .Get(moveRequest)
                .ExecuteAsync(moveRequest);

            potOut = moveResponse.Pot;
            playersOut.Add(moveResponse.ParticipantInTurn);

            playerInTurn = request.Participants.NextParticipant(playerInTurn);
        }

        return new PhaseResponse
        {
            Deck = deckOut,
            CommunityCards = ccOut,
            Participants = playersOut,
            Winners = [],
            GameOver = false,
            Pot = potOut
        };
    }
}
