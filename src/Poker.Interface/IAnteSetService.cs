namespace Poker.Service.Interface;

public interface IAnteSetService
{
    Task<uint> GetAsync(GameRequest gameRequest, Player button);
}
