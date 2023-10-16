namespace Poker.Service;

public class AutomatonMoveService : IAutomatonMoveService
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

    private Task<MoveResponse> DefaultMoveAsync(MoveRequest request)
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
        var stackOut = request.PlayerInTurn.Participant.Stack;

        var ante = request.PhaseRequest.Game.Ante;

        _userInterfaceService
            .WriteLines($"{request.PlayerInTurn.Participant.Name} antes.");

        stackOut -= ante;

        return Task.FromResult(
            new MoveResponse
            {
                PlayerInTurn = request.PlayerInTurn with
                {
                    Participant = request.PlayerInTurn.Participant with {
                        Stack = stackOut
                    }
                },
                Deck = request.PhaseRequest.Game.Deck,
                Pot = request.Pot + ante
            }
        );
    }

    private Task<MoveResponse> DealAsync(MoveRequest request)
    {
        var playerCardsOut = request.PlayerInTurn.Cards;
        var deckCardsOut = request.PhaseRequest.Game.Deck.Cards;

        var dealtCards = deckCardsOut
            .Take(request.PhaseRequest.Phase.CardsToDealCount);

        playerCardsOut.AddRange(dealtCards);

        deckCardsOut.RemoveAll(
            c => dealtCards
                .Select(x => x.Value)
                .Contains(c.Value)
        );

        return Task.FromResult(
            new MoveResponse
            {
                PlayerInTurn = request.PlayerInTurn with { Cards = playerCardsOut },
                Deck = request.PhaseRequest.Game.Deck with { Cards = deckCardsOut },
                Pot = request.Pot
            }
        );
    }
}
