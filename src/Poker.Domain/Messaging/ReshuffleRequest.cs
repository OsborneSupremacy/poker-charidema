namespace Poker.Domain.Messaging;

public record ReshuffleRequest
{
    public required IReadOnlyList<Participant> Participants { get; init; }

    public required Deck Deck { get; init; }
}
