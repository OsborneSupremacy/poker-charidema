namespace Poker.Service.Interface;

public interface IPhaseTransitionService
{
    public Task<PhaseTransitionResponse> ExecuteAsync(PhaseTransitionRequest request);
}
