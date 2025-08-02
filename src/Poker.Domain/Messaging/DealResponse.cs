namespace Poker.Domain.Messaging;

public record DealResponse
{
    public required Deck Deck { get; init; }

    public required IReadOnlyList<Participant> Participants { get; init; }

    public required IReadOnlyList<CardInPlay> CommunityCards { get; init; }
}
