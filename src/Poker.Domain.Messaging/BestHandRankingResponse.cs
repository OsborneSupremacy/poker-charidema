namespace Poker.Domain.Messaging;

public record BestHandRankingResponse
{
    public required Hand HandRanking { get; init; }

    public required HandRankingResponse HandRankingResult { get; init; }
}
