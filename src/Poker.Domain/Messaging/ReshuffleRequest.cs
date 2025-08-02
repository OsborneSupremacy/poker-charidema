namespace Poker.Domain.Messaging;

public record ReshuffleRequest
{
    public required List<Participant> Participants { get; init; }

    public required Deck Deck { get; init; }
}
