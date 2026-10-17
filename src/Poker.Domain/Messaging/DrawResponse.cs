namespace Poker.Domain.Messaging;

public record DrawResponse
{
    public required Participant Participant { get; init; }

    public required Deck Deck { get; init; }

    public required IReadOnlyList<CardInPlay> Discards { get; init; }

    public required IReadOnlyList<Card> CardsDrawn { get; init; }
}
