namespace Poker.Service.Abstractions;

public interface IRandomFactory
{
    Random Create();

    int GetSeed();
}
