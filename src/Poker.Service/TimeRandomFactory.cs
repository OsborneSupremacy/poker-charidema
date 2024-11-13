namespace Poker.Service;

internal class TimeRandomFactory : IRandomFactory
{
    public Random Create() =>
        new(GetSeed());

    public int GetSeed() =>
        DateTime.Now.Millisecond;
}
