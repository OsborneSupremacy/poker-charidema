namespace Poker.Domain.Messaging;

public record GameRequest
{
    public required Match Match { get; init; }

    public required List<Player> Players { get; init; }

    public required Variant Variant { get; init; }

    public required Deck Deck { get; init; }

    public required Player Button { get; init; }
}
