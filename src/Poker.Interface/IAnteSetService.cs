namespace Poker.Service.Interface;

public interface IAnteSetService
{
    Task<uint> GetAsync(GameArgs gameArgs, Player button);
}
