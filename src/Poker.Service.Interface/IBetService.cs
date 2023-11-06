namespace Poker.Service.Interface;

public interface IBetService
{
    public BetResponse Execute(BetRequest request);
}
