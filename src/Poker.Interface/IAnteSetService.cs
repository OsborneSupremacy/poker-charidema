using Poker.Domain.Messaging;

namespace Poker.Service.Interface;

public interface IAnteSetService
{
    Task<uint> GetAsync(GameRequest gameRequest, Player button);
}
