namespace Poker.Service.Abstractions;

public interface IPhaseCoordinator
{
    public Task<CoordinatePhaseResponse> ExecuteAsync(CoordinatePhaseRequest request);
}
