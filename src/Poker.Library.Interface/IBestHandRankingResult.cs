namespace Poker.Library.Interface;

public interface IBestHandRankingResult
{
    IHandRanking HandRanking { get; }

    IHandRankingResult HandRankingResult { get; }
}
