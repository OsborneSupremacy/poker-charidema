namespace Poker.Test.Utility;

/// <summary>
/// Serves as its own move service factory. Responds to every move request
/// with the given response function, and records the requests it receives.
/// </summary>
public class TestMoveService : IMoveServiceFactory, IMoveService
{
    private readonly Func<MoveRequest, MoveResponse> _respond;

    private readonly List<MoveRequest> _requests = [];

    public TestMoveService(Func<MoveRequest, MoveResponse> respond)
    {
        _respond = respond;
    }

    public IReadOnlyList<MoveRequest> Requests => _requests;

    public IMoveService Get(MoveRequest request) => this;

    public Task<MoveResponse> ExecuteAsync(MoveRequest request)
    {
        _requests.Add(request);
        return Task.FromResult(_respond(request));
    }
}
