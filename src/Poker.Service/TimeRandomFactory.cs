using Bogus;

namespace Poker.Service;

public class TimeRandomFactory : IRandomFactory
{
    public Random Create() =>
        new(DateTime.Now.Millisecond);

    public Faker CreateFaker() =>
        new()
        {
            Random = new Randomizer(GetSeed())
        };

    public int GetSeed() =>
        DateTime.Now.Millisecond;
}
