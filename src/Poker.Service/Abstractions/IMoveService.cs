namespace Poker.Service.Abstractions;

public interface IMoveService
{
    public Task<MoveResponse> ExecuteAsync(MoveRequest request);
}
