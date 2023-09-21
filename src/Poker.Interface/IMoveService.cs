namespace Poker.Service.Interface;

public interface IMoveService
{
    public Task<MoveResponse> ExecuteAsync(MoveRequest request);
}
