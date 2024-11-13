namespace Poker.Service.Abstractions;

public interface IMatchService
{
    Task<MatchResponse> PlayAsync(MatchRequest request);
}
