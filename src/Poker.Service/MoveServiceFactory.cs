namespace Poker.Service;

/// <inheritdoc />
internal class MoveServiceFactory : IMoveServiceFactory
{
    private readonly IUserMoveService _userMoveService;

    private readonly IAutomatonMoveService _automatonMoveService;

    public MoveServiceFactory(
        IUserMoveService userMoveService,
        IAutomatonMoveService automatonMoveService
        )
    {
        _userMoveService = userMoveService ?? throw new ArgumentNullException(nameof(userMoveService));
        _automatonMoveService = automatonMoveService ?? throw new ArgumentNullException(nameof(automatonMoveService));
    }

    public IMoveService Get(MoveRequest request) =>
        RequiresUserInput(request) switch
        {
            true => _userMoveService,
            false => _automatonMoveService
        };

    static readonly Func<MoveRequest, bool> RequiresUserInput = request =>
        !request.PlayerInTurn.Automaton
        && request.PhaseRequest.Phase.PhaseType != PhaseType.Deal;
}
