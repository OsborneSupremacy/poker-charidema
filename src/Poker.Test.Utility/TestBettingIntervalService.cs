namespace Poker.Test.Utility;

/// <summary>
/// Responds to each betting interval request with the next scripted response,
/// and records the requests it receives.
/// </summary>
public class TestBettingIntervalService : IBettingIntervalService
{
    private readonly Queue<Func<BettingIntervalRequest, BettingIntervalResponse>> _responses;

    private readonly List<BettingIntervalRequest> _requests = [];

    public TestBettingIntervalService(params Func<BettingIntervalRequest, BettingIntervalResponse>[] responses)
    {
        _responses = responses.ToQueue();
    }

    public IReadOnlyList<BettingIntervalRequest> Requests => _requests;

    public Task<BettingIntervalResponse> ExecuteAsync(BettingIntervalRequest request)
    {
        _requests.Add(request);
        return Task.FromResult(_responses.Dequeue()(request));
    }
}
