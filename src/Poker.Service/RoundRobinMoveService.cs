namespace Poker.Service;

public class RoundRobinMoveService : IPhaseService
{
    private readonly IMoveServiceFactory _moveServiceFactory;

    public RoundRobinMoveService(IMoveServiceFactory moveServiceFactory)
    {
        _moveServiceFactory = moveServiceFactory ?? throw new ArgumentNullException(nameof(moveServiceFactory));
    }

    public async Task<PhaseResponse> ExecuteAsync(PhaseRequest request)
    {
        var playersOut = new List<Player>();

        var ccOut = request.CommunityCards;
        var deckOut = request.Deck;
        var potOut = request.Pot;

        // TODO: if this is a betting round and any non-community cards are face-up, start with player showing
        // best hand. Otherwise, start with player to the left of dealer
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
            GameOver = false,
            Pot = potOut
        };
    }
}
