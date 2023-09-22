namespace Poker.Service.Interface;

public interface IMatchPreferencesService
{
    Task<bool> ConfirmStartAsync();

    Task<MatchRequest> GetMatchRequest(MatchResponse? lastMatch);

    Task<bool> GetPlayAgain(Match lastMatch);
}
