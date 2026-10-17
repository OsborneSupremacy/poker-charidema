namespace Poker.Test.Utility;

/// <summary>
/// Responds to every discard selection request with the given selection function,
/// and records the requests it receives. Serves as either the user or the
/// automaton selection service.
/// </summary>
public class TestDiscardSelectionService : IUserDiscardSelectionService, IAutomatonDiscardSelectionService
{
    private readonly Func<DiscardSelectionRequest, IReadOnlyList<Card>> _select;

    private readonly List<DiscardSelectionRequest> _requests = [];

    public TestDiscardSelectionService(Func<DiscardSelectionRequest, IReadOnlyList<Card>> select)
    {
        _select = select;
    }

    public IReadOnlyList<DiscardSelectionRequest> Requests => _requests;

    public Task<IReadOnlyList<Card>> SelectAsync(DiscardSelectionRequest request)
    {
        _requests.Add(request);
        return Task.FromResult(_select(request));
    }
}
