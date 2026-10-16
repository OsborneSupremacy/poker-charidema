namespace Poker.Test.Utility;

/// <summary>
/// Returns the same betting interval options for every request.
/// </summary>
public class TestBettingIntervalOptionsService : IBettingIntervalOptionsService
{
    private readonly BettingIntervalOptionsResponse _response;

    public TestBettingIntervalOptionsService(BettingIntervalOptionsResponse response)
    {
        _response = response;
    }

    public Task<BettingIntervalOptionsResponse> ExecuteAsync(BettingIntervalOptionsRequest request) =>
        Task.FromResult(_response);
}
