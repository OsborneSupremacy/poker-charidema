namespace Poker.Domain.Messaging;

public record DrawRequest
{
    public required Participant Participant { get; init; }

    public required IReadOnlyList<Card> CardsToDiscard { get; init; }

    public required Deck Deck { get; init; }

    public required IReadOnlyList<CardInPlay> Discards { get; init; }

    public required CardOrientation CardOrientation { get; init; }
}
