namespace Poker.Interface;

public interface IDealerService
{
    Task<IDeck> ShuffleAsync(IDeck deck);
}
