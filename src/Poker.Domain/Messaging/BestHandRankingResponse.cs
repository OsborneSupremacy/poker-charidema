namespace Poker.Domain.Messaging;

public record BestHandRankingResponse
{
    public required QualifiedHandResponse HandQualificationResponse { get; init; }
}
