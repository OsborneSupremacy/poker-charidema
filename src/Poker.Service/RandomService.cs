using Bogus;

namespace Poker.Service;

/// <inheritdoc />
internal class RandomService : IRandomService
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

    public T PickFromReadOnlyList<T>(IReadOnlyList<T> items) =>
        new Faker
        {
            Random = new Randomizer(_randomFactory.GetSeed())
        }.PickRandom(items.ToList());

    public Person CreatePerson() =>
        new Faker
        {
            Random = new Randomizer(_randomFactory.GetSeed())
        }.Person;

    public int GetAmount(int min, int max)
    {
        if (min > max)
            (max, min) = (min, max);
        return new Randomizer(_randomFactory.GetSeed()).Int(min, max);
    }
}
