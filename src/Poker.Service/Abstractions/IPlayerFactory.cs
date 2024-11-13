using Poker.Service.Messaging;

namespace Poker.Service.Abstractions;

public interface IPlayerFactory
{
    public Task<Player> CreateAsync(PlayerCreateRequest request);
}
