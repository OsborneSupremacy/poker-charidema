namespace Poker.Service.Interface;

public interface IMatchPreferencesService
{
    Task<bool> ConfirmStartAsync();

    Task<MatchArgs> GetMatchArgs();

    Task<bool> GetPlayAgain();

    void Write(string input);

    void WriteLine(string input);

    void WriteLine();
}
