namespace Poker.Service;

/// <inheritdoc />
internal class UserMoveService : IUserMoveService
{
    private readonly IUserInterfaceService _userInterfaceService;

    public UserMoveService(
        IUserInterfaceService userInterfaceService
        )
    {
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
    }

    public Task<MoveResponse> ExecuteAsync(MoveRequest request) =>
        request.PhaseRequest.Phase.PhaseType switch
        {
            PhaseType.Ante => AntePromptAsync(request),
            _ => DefaultMoveAsync(request)
        };

    private Task<MoveResponse> DefaultMoveAsync(MoveRequest request)
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

    private Task<MoveResponse> AntePromptAsync(MoveRequest request) =>
        _userInterfaceService.PromptForBool($"Ante {request.PhaseRequest.Game.Ante:C0}?") switch
        {
            true => AnteAsync(request),
            false => SitOutAsync(request)
        };

    private Task<MoveResponse> AnteAsync(MoveRequest request)
    {
        var ante = request.PhaseRequest.Game.Ante;

        _userInterfaceService
            .WriteLines($"{request.ParticipantInTurn.Name} antes.");

        return Task.FromResult(
            new MoveResponse
            {
                ParticipantInTurn = request.ParticipantInTurn with
                {
                    Stack = request.ParticipantInTurn.Stack - ante,
                    Stake = request.ParticipantInTurn.Stake + ante
                },
                Deck = request.PhaseRequest.Game.Deck,
                Pot = request.Pot + ante
            }
        );
    }

    private Task<MoveResponse> SitOutAsync(MoveRequest request)
    {
        _userInterfaceService
            .WriteLines($"{request.ParticipantInTurn.Name} sits out.");

        return Task.FromResult(
            new MoveResponse
            {
                ParticipantInTurn = request.ParticipantInTurn with
                {
                    Folded = true
                },
                Deck = request.PhaseRequest.Game.Deck,
                Pot = request.Pot
            }
        );
    }
}
