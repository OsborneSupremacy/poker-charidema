namespace Poker.Service.Interface;

public interface IMoveService
{
    public MoveResult Execute(MoveArgs args);
}
