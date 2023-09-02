namespace Poker.Service.Interface;

public interface IMatchPreferencesService
{
    Task<bool> ConfirmStartAsync();

    Task<MatchArgs> GetMatchArgs(Match? lastMatch);

    Task<bool> GetPlayAgain(Match lastMatch);
}
