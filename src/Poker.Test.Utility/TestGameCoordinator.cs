namespace Poker.Test.Utility;

/// <summary>
/// Responds to each game request with the next scripted response,
/// and records the requests it receives.
/// </summary>
public class TestGameCoordinator : IGameCoordinator
{
    private readonly Queue<Func<CoordinateGameRequest, CoordinateGameResponse>> _responses;

    private readonly List<CoordinateGameRequest> _requests = [];

    public TestGameCoordinator(params Func<CoordinateGameRequest, CoordinateGameResponse>[] responses)
    {
        _responses = responses.ToQueue();
    }

    public IReadOnlyList<CoordinateGameRequest> Requests => _requests;

    public Task<CoordinateGameResponse> ExecuteAsync(CoordinateGameRequest request)
    {
        _requests.Add(request);
        return Task.FromResult(_responses.Dequeue()(request));
    }
}
