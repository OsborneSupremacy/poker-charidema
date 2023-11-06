namespace Poker.Service.Interface;

public interface IBetOptionsService
{
    public Task<BetOptionsResponse> ExecuteAsync(BetOptionsRequest request);
}
