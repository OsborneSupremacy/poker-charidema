namespace Poker.Service.Interface;

public interface IMoveServiceFactory
{
    IMoveService Get(MoveArgs args);
}
