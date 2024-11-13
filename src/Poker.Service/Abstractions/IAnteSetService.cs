namespace Poker.Service.Abstractions;

public interface IAnteSetService
{
    Task<int> GetAsync(GameRequest gameRequest, Player button);
}
