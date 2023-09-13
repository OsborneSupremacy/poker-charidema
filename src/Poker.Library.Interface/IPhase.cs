namespace Poker.Library.Interface;

public interface IPhase
{
    public string Name { get; }

    bool GameCanEndAfter { get; }
}
