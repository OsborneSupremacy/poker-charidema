namespace Poker.Domain.Messaging;

public record MoveResponse
{
    public required Player PlayerInTurn { get; init; }

    public required Deck Deck { get; init; }

    public required int Pot { get; set; }
}
