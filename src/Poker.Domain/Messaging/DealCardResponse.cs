namespace Poker.Domain.Messaging;

public record DealCardResponse
{
    public required Card Card { get; init; }

    public required Deck Deck { get; init; }

    public required Player Player { get; init; }
}
