namespace Poker.Domain.Messaging;

public record HandRankingRequest
{
    public required Deck Deck { get; init; }

    public required List<Card> PlayerCards { get; init; }
}
