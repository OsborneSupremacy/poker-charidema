namespace Poker.Service.Abstractions;

public interface IPhaseService
{
    public Task<PhaseResponse> ExecuteAsync(PhaseRequest request);
}
