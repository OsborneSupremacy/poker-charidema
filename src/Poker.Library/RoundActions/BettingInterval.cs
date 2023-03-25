namespace Poker.Library.RoundActions;

public record class BettingInterval : IRoundAction
{
    public bool GameCanEndAfter => true;
}
