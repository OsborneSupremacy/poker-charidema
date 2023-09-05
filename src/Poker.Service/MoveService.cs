﻿using Poker.Library.Rounds;

namespace Poker.Service;

public class MoveService : IMoveService
{
    private readonly IUserInterfaceService _userInterfaceService;

    public MoveService(IUserInterfaceService userInterfaceService)
    {
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
    }

    public Task<MoveResult> ExecuteAsync(MoveArgs args)
    {
        if(args.RoundArgs.Round is Ante)
        {
            _userInterfaceService
                .WriteLines($"{args.PlayerInTurn.Player.Name} antes.");
        }
        else
        {
            _userInterfaceService
                .WriteLines($"{args.PlayerInTurn.Player.Name}'s turn.");
        }

        return Task.FromResult(new MoveResult { });
    }
}
