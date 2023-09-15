namespace Poker.Domain.Messaging;

public record PossibleHandRankingResponse
{
    public required bool Qualifies { get; init; }

    public required List<Card> HandCards { get; init; }

    public required List<Card> NonHandCards { get; init; }
}
