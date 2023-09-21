namespace Poker.Service.Interface;

public interface IMoveServiceFactory
{
    IMoveService Get(MoveRequest request);
}
