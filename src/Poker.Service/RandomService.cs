using Bogus;
using Poker.Domain.Abstractions;

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

    public T PickFromWeightedList<T>(IReadOnlyList<T> items) where T : IWeightedItem
    {
        var list = new List<T>();
        foreach (var item in items)
            for (var i = 0; i < item.Weight; i++)
                list.Add(item);
        return PickFromList(list);
    }

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
