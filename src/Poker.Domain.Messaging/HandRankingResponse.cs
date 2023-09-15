namespace Poker.Domain.Messaging;

public record HandRankingResponse
{
    public required bool Qualifies { get; init; }

    public required List<Card> HandCards { get; init; }

    public required List<Card> Kickers { get; init; }

    public required List<Card> DeadCards { get; init; }
}
