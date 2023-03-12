namespace Poker.Library.RoundActions;

public record class AcceptBets : RoundAction
{
    public override bool GameCanEndAfter => true;
}
