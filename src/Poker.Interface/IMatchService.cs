namespace Poker.Service.Interface;

public interface IMatchService
{
    Task<MatchResult> PlayAsync(MatchArgs args);
}
