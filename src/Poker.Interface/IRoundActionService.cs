using Poker.Library.RoundActions;

namespace Poker.Interface;

public interface IRoundActionService
{
    public Task<RoundActionResult> ExecuteAsync(RoundActionArgs ags);
}
