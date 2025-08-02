namespace Poker.Domain.Messaging;

public record DealRequest
{
    public required Deck Deck { get; init; }

    public required List<Participant> Participants { get; init; }

    public required List<CardInPlay> CommunityCards { get; init; }

    public required Participant StartingParticipant { get; init; }

    public required int CardsToDealCount { get; init; }

    public required CardOrientation CardOrientation { get; init; }
}
