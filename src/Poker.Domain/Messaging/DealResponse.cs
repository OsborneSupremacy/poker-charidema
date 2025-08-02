namespace Poker.Domain.Messaging;

public record DealResponse
{
    public required Deck Deck { get; init; }

    public required List<Participant> Participants { get; init; }

    public required List<CardInPlay> CommunityCards { get; init; }
}
