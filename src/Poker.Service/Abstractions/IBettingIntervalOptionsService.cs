namespace Poker.Service.Abstractions;

/// <summary>
/// Gets the options available to current bettor during a betting interval.
/// </summary>
public interface IBettingIntervalOptionsService
{
    public Task<BettingIntervalOptionsResponse> ExecuteAsync(BettingIntervalOptionsRequest request);
}
