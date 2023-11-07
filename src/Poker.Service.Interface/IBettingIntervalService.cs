namespace Poker.Service.Interface;

public interface IBettingIntervalService
{
    public Task<BettingIntervalResponse> ExecuteAsync(BettingIntervalRequest request);
}
