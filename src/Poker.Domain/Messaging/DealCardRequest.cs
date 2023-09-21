namespace Poker.Domain.Messaging;

public record DealCardRequest
{
    public required Deck Deck { get; init; }

    public required Player Player { get; init; }

    public required Phase Phase { get; init; }
}
