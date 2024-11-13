namespace Poker.Service.Abstractions;

public interface IBettingIntervalService
{
    public Task<BettingIntervalResponse> ExecuteAsync(BettingIntervalRequest request);
}
