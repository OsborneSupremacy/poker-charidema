namespace Poker.Service.Abstractions;

public interface IGameService
{
    public Task<GameResponse> PlayAsync(GameRequest request);
}
