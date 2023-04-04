namespace Poker.Service.Interface;

public interface IDealerService
{
    Task<IDeck> ShuffleAsync(IDeck deck);
}
