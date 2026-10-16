namespace Poker.Test.Utility;

/// <summary>
/// Returns the same lead player response for every request.
/// </summary>
public class TestLeadPlayerService : ILeadPlayerService
{
    private readonly EvaluateLeaderPlayerResponse _response;

    public TestLeadPlayerService(EvaluateLeaderPlayerResponse response)
    {
        _response = response;
    }

    public Task<EvaluateLeaderPlayerResponse> ExecuteAsync(EvaluateLeadParticipantRequest request) =>
        Task.FromResult(_response);
}
