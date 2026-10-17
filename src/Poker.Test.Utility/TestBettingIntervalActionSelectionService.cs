namespace Poker.Test.Utility;

/// <summary>
/// Responds to every betting interval action selection request with the given selection,
/// and records the requests it receives. Serves as either the user or the automaton
/// selection service.
/// </summary>
public class TestBettingIntervalActionSelectionService
    : IUserBettingIntervalActionSelectionService, IAutomatonBettingIntervalActionSelectionService
{
    private readonly BettingIntervalActionSelectionResponse _response;

    private readonly List<BettingIntervalActionSelectionRequest> _requests = [];

    public TestBettingIntervalActionSelectionService(BettingIntervalActionSelectionResponse response)
    {
        _response = response;
    }

    public IReadOnlyList<BettingIntervalActionSelectionRequest> Requests => _requests;

    public Task<BettingIntervalActionSelectionResponse> SelectAsync(BettingIntervalActionSelectionRequest request)
    {
        _requests.Add(request);
        return Task.FromResult(_response);
    }
}
