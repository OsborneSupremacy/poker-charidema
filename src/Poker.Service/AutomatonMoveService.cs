namespace Poker.Service;

internal class AutomatonMoveService : IAutomatonMoveService
{
    private readonly IUserInterfaceService _userInterfaceService;

    public AutomatonMoveService(IUserInterfaceService userInterfaceService)
    {
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
    }

    public Task<MoveResponse> ExecuteAsync(MoveRequest request) =>
        request.PhaseRequest.Phase.PhaseType switch
        {
            PhaseType.Ante => AnteAsync(request),
            PhaseType.Deal => DealAsync(request),
            _ => DefaultMoveAsync(request)
        };

    private static Task<MoveResponse> DefaultMoveAsync(MoveRequest request)
    {
        int potOut = request.Pot;

        return Task.FromResult(
            new MoveResponse
            {
                PlayerInTurn = request.PlayerInTurn,
                Deck = request.PhaseRequest.Game.Deck,
                Pot = potOut
            }
        );
    }

    private Task<MoveResponse> AnteAsync(MoveRequest request)
    {
        var ante = request.PhaseRequest.Game.Ante;

        _userInterfaceService
            .WriteLines($"{request.PlayerInTurn.Name} antes.");

        return Task.FromResult(
            new MoveResponse
            {
                PlayerInTurn = request.PlayerInTurn with
                {
                    Stack = request.PlayerInTurn.Stack - ante
                },
                Deck = request.PhaseRequest.Game.Deck,
                Pot = request.Pot + ante
            }
        );
    }

    private static Task<MoveResponse> DealAsync(MoveRequest request)
    {
        var playerCardsOut = request.PlayerInTurn.CardsInPlay;
        var deckCardsOut = request.PhaseRequest.Game.Deck.Cards
            .ToQueue();

        for (int x = 0; x < request.PhaseRequest.Phase.CardsToDealCount; x++)
        {
            var card = deckCardsOut.Dequeue()
                .DealToPlayer(request.PhaseRequest.Phase.CardOrientation);
            playerCardsOut.Add(card);
        }

        return Task.FromResult(
            new MoveResponse
            {
                PlayerInTurn = request.PlayerInTurn with { CardsInPlay = playerCardsOut },
                Deck = request.PhaseRequest.Game.Deck with { Cards = deckCardsOut.ToList() },
                Pot = request.Pot
            }
        );
    }
}
