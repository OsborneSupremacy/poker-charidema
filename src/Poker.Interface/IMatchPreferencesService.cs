namespace Poker.Interface;

public interface IMatchPreferencesService
{
    Task<MatchArgs> GetMatchArgs();

    Task<bool> GetPlayAgain();
}
