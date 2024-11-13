namespace Poker.Service.Abstractions;

public interface IGameCoordinator
{
    Task<MatchMessage> ExecuteAsync(GameRequest request);
}
