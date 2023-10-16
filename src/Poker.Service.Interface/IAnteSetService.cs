namespace Poker.Service.Interface;

public interface IAnteSetService
{
    Task<int> GetAsync(GameRequest gameRequest, Player button);
}
