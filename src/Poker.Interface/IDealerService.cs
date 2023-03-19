
namespace Poker.Interface;

public interface IDealerService
{
    Task<Deck> ShuffleAsync(Deck deck);
}
