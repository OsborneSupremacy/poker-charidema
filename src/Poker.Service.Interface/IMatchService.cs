namespace Poker.Service.Interface;

public interface IMatchService
{
    Task<MatchResponse> PlayAsync(MatchRequest request);
}
