namespace Poker.Service.Abstractions;

public interface IMoveServiceFactory
{
    IMoveService Get(MoveRequest request);
}
