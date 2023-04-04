namespace Poker.Interface;

public interface IMatchService
{
    Task<MatchResult> PlayAsync(MatchArgs args);
}
