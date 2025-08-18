using Bogus;
using Poker.Domain.Abstractions;

namespace Poker.Service.Abstractions;

public interface IRandomService
{
    public T PickFromList<T>(IList<T> items);

    public T PickFromReadOnlyList<T>(IReadOnlyList<T> items);

    public T PickFromWeightedList<T>(IReadOnlyList<T> items) where T : IWeightedItem;

    public Person CreatePerson();

    public int GetAmount(int min, int max);
}
