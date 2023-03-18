

namespace Poker.Interface;

public interface IGameService
{
    public Task<Game> PlayAsync(GameArgs args);
}
