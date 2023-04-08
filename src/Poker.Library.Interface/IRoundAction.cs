namespace Poker.Library.Interface;

public interface IRoundAction
{
    public string Name { get; }

    bool GameCanEndAfter { get; }
}
