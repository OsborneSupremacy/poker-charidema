namespace Poker.Service.Abstractions;

public interface IMatchPreferencesService
{
    Task<bool> ConfirmStartAsync();

    Task<MatchRequest> CreateMatchRequest(MatchResponse? lastMatch);

    Task<bool> GetPlayAgain(Match lastMatch);
}
