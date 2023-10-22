namespace Poker.Service.Interface;

public interface IGameCoordinator
{
    Task<MatchMessage> ExecuteAsync(GameRequest request);
}
