using Poker.Library.Rounds;

namespace Poker.Service.Interface;

public interface IRoundService
{
    public Task<RoundResult> ExecuteAsync(RoundArgs ags);
}
