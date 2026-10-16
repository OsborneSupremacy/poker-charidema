using Bogus;

namespace Poker.Test.Utility;

/// <summary>
/// Makes predictable "random" choices: always picks the first item from a list,
/// and always returns the amount it was created with.
/// </summary>
public class TestRandomService : IRandomService
{
    private readonly int _amount;

    public TestRandomService(int amount)
    {
        _amount = amount;
    }

    public T PickFromList<T>(IList<T> items) => items.First();

    public T PickFromReadOnlyList<T>(IReadOnlyList<T> items) => items.First();

    public T PickFromWeightedList<T>(IReadOnlyList<T> items) where T : IWeightedItem => items.First();

    public Person CreatePerson() => throw new NotSupportedException();

    public int GetAmount(int min, int max) => _amount;
}
