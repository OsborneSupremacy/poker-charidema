namespace Poker.Service.Interface;

public interface IMatchPreferencesService
{
    Task<MatchArgs> GetMatchArgs();

    Task<bool> GetPlayAgain();
}
