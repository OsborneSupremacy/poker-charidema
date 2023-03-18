namespace Poker.Library.RoundActions;

public record class BettingInterval : RoundAction
{
    public override bool GameCanEndAfter => true;
}
