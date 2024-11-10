using Bogus;

namespace Poker.Service;

public class RandomService : IRandomService
{
    private readonly IRandomFactory _randomFactory;

    public RandomService(IRandomFactory randomFactory)
    {
        _randomFactory = randomFactory ?? throw new ArgumentNullException(nameof(randomFactory));
    }

    public T PickFromList<T>(IList<T> items) =>
        new Faker
        {
            Random = new Randomizer(_randomFactory.GetSeed())
        }.PickRandom(items);

    public Person CreatePerson() =>
        new Faker
        {
            Random = new Randomizer(_randomFactory.GetSeed())
        }.Person;

    public int GetAmount(int min, int max) =>
        new Randomizer(_randomFactory.GetSeed()).Int(min, max);
}
