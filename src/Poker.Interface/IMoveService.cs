namespace Poker.Service.Interface;

public interface IMoveService
{
    public Task<MoveResult> ExecuteAsync(MoveArgs args);
}
