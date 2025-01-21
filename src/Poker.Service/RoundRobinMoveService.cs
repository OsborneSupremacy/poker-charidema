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

        var playersOut = new List<Player>();

        var ccOut = request.CommunityCards;
        var deckOut = request.Deck;
        var potOut = request.Pot;

        var playerInTurn = request.StartingPlayer;

        while (playersOut.Count < request.Game.Players.Count)
        {
            MoveRequest moveRequest = new()
            {
                PlayerInTurn = playerInTurn,
                PhaseRequest = request,
                Pot = potOut
            };

            var moveResponse = await _moveServiceFactory
                .Get(moveRequest)
                .ExecuteAsync(moveRequest);

            potOut = moveResponse.Pot;
            playersOut.Add(moveResponse.PlayerInTurn);

            playerInTurn = request.Game.Players.NextPlayer(playerInTurn);
        }

        return new PhaseResponse
        {
            Deck = deckOut,
            CommunityCards = ccOut,
            Players = playersOut,
            Winners = [],
            GameOver = false,
            Pot = potOut
        };
    }
}
