namespace Poker.Service.Abstractions;

public interface IPhaseCoordinator
{
    public Task<PhaseCoordinatorResponse> ExecuteAsync(PhaseCoordinatorRequest request);
}
