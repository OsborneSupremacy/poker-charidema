using Bogus;

namespace Poker.Service.Interface;

public interface IRandomService
{
    public T PickFromList<T>(IList<T> items);
    
    public Person CreatePerson();
    
    public int GetAmount(int min, int max);
}
