namespace Poker.Library.RoundActions;

public abstract record class RoundAction
{
    public abstract bool GameCanEndAfter { get; }
}
