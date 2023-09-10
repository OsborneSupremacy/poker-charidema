namespace Poker.Service;

public class MoveServiceFactory : IMoveServiceFactory
{
    private readonly IUserMoveService _userMoveService;

    private readonly IAutomatonMoveService _automatonMoveService;

    public MoveServiceFactory(IUserMoveService userMoveService, IAutomatonMoveService automatonMoveService)
    {
        _userMoveService = userMoveService ?? throw new ArgumentNullException(nameof(userMoveService));
        _automatonMoveService = automatonMoveService ?? throw new ArgumentNullException(nameof(automatonMoveService));
    }

    public IMoveService Get(MoveArgs args) =>
        args.PlayerInTurn.Player.Automaton switch
        {
            true => _automatonMoveService,
            false => _userMoveService
        };
}
