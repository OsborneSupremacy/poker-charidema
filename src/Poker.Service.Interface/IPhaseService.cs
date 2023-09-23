namespace Poker.Service.Interface;

public interface IPhaseService
{
    public Task<PhaseResponse> ExecuteAsync(PhaseRequest request);
}
