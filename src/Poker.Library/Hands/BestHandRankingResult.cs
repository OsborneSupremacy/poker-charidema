namespace Poker.Library.Hands;

public class BestHandRankingResult : IBestHandRankingResult
{
    public required IHandRanking HandRanking { get; init; }

    public required IHandRankingResult HandRankingResult { get; init; }
}
