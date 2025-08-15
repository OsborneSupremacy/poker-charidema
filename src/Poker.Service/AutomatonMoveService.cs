namespace Poker.Service;

/// <inheritdoc />
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
                ParticipantInTurn = request.ParticipantInTurn,
                Deck = request.PhaseRequest.Deck,
                Pot = potOut
            }
        );
    }

    private Task<MoveResponse> AnteAsync(MoveRequest request)
    {
        var ante = request.PhaseRequest.Ante;

        _userInterfaceService
            .WriteLines($"{request.ParticipantInTurn.Name} antes.");

        return Task.FromResult(
            new MoveResponse
            {
                ParticipantInTurn = request.ParticipantInTurn with
                {
                    Stack = request.ParticipantInTurn.Stack - ante,
                    Stake = request.ParticipantInTurn.Stake + ante,
                },
                Deck = request.PhaseRequest.Deck,
                Pot = request.Pot + ante
            }
        );
    }

    private static Task<MoveResponse> DealAsync(MoveRequest request)
    {
        var playerCardsOut = request.ParticipantInTurn.CardsInPlay.ToList();
        var deckCardsOut = request.PhaseRequest.Deck.Cards
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
                ParticipantInTurn = request.ParticipantInTurn with { CardsInPlay = playerCardsOut },
                Deck = request.PhaseRequest.Deck with { Cards = deckCardsOut.ToList() },
                Pot = request.Pot
            }
        );
    }
}
