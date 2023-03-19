namespace Poker.Test.Utility;

public class TestRandomFactory : IRandomFactory
{
    private readonly int _seed;

    public TestRandomFactory(int seed)
    {
        _seed = seed;
    }

    public Random Create()
    {
        return new Random(_seed);
    }
}
