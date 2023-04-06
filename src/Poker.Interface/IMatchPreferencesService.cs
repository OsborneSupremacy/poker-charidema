namespace Poker.Service.Interface;

public interface IMatchPreferencesService
{
    Task<bool> ConfirmStartAsync();

    Task<MatchArgs> GetMatchArgs(Match? lastMatch);

    Task<bool> GetPlayAgain();

    IMatchPreferencesService Write(string input);

    IMatchPreferencesService WriteLine(string input);

    IMatchPreferencesService WriteLines(params string[] lines);

    IMatchPreferencesService WriteLine();
}
