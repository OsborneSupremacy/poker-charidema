using Poker.Library.Phases;

namespace Poker.Service.Interface;

public interface IPhaseService
{
    public Task<PhaseResult> ExecuteAsync(PhaseArgs ags);
}
