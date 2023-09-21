namespace Poker.Service.Interface;

public interface IGameService
{
    public Task<GameResponse> PlayAsync(GameRequest request);
}
