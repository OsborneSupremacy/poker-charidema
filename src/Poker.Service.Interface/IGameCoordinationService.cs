namespace Poker.Service.Interface;

public interface IGameCoordinationService
{
    Task<MatchMessage> ExecuteAsync(GameRequest request);
}
