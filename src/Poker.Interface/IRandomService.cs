namespace Poker.Interface;

public interface IRandomFactory
{
    Random Create();

    int GetSeed();
}
