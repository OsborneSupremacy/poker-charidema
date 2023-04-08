﻿namespace Poker.Library.RoundActions;

public record BettingInterval : IRoundAction
{
    public string Name => "Bet";

    public bool GameCanEndAfter => true;
}
