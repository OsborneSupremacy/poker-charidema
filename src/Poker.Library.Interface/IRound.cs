namespace Poker.Library.Interface;

public interface IRound
{
    public string Name { get; }

    bool GameCanEndAfter { get; }
}
