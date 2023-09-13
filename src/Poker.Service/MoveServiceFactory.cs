﻿using Poker.Library.Rounds;

namespace Poker.Service;

public class MoveServiceFactory : IMoveServiceFactory
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

    public IMoveService Get(MoveArgs args) =>
        _requiresUserInput(args) switch
        {
            true => _userMoveService,
            false => _automatonMoveService
        };

    readonly static Func<MoveArgs, bool> _requiresUserInput = (MoveArgs args) =>
    {
        return
            args.PlayerInTurn.Player.Automaton
            || (args.RoundArgs.Round is DealCards);
    };
}
