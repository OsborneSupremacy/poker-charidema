using Poker.Library.RoundActions;

namespace Poker.Service.Interface;

public interface IRoundActionService
{
    public Task<RoundActionResult> ExecuteAsync(RoundActionArgs ags);
}
