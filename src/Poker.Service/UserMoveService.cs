namespace Poker.Service;

public class UserMoveService : IUserMoveService
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
                PlayerInTurn = request.PlayerInTurn,
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
            .WriteLines($"{request.PlayerInTurn.Name} antes.");

        return Task.FromResult(
            new MoveResponse
            {
                PlayerInTurn = request.PlayerInTurn with
                {
                    Stack = request.PlayerInTurn.Stack - ante,
                    Stake = request.PlayerInTurn.Stake + ante
                },
                Deck = request.PhaseRequest.Game.Deck,
                Pot = request.Pot + ante
            }
        );
    }

    private Task<MoveResponse> SitOutAsync(MoveRequest request)
    {
        _userInterfaceService
            .WriteLines($"{request.PlayerInTurn.Name} sits out.");

        return Task.FromResult(
            new MoveResponse
            {
                PlayerInTurn = request.PlayerInTurn with
                {
                    Folded = true
                },
                Deck = request.PhaseRequest.Game.Deck,
                Pot = request.Pot
            }
        );
    }
}
