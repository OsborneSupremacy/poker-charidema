namespace Poker.Test.Utility;

/// <summary>
/// Gives the same answers to every match preference prompt.
/// </summary>
public class TestMatchPreferencesService : IMatchPreferencesService
{
    private readonly bool _confirmStart;

    private readonly bool _playAgain;

    public TestMatchPreferencesService(bool confirmStart, bool playAgain)
    {
        _confirmStart = confirmStart;
        _playAgain = playAgain;
    }

    public Task<bool> ConfirmStartAsync() => Task.FromResult(_confirmStart);

    public Task<MatchRequest> CreateMatchRequest(MatchResponse lastMatch) =>
        throw new NotSupportedException();

    public Task<bool> GetPlayAgain(Match lastMatch) => Task.FromResult(_playAgain);
}
