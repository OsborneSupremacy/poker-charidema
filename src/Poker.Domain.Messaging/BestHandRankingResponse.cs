namespace Poker.Domain.Messaging;

public record BestHandRankingResponse
{
    public required HandRanking HandRanking { get; init; }

    public required HandRankingResponse HandRankingResult { get; init; }
}
