namespace Poker.Service.Interface;

public interface IPhaseCoordinator
{
    public Task<PhaseCoordinatorResponse> ExecuteAsync(PhaseCoordinatorRequest request);
}
