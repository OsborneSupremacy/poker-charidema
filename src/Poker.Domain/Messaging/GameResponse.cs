namespace Poker.Domain.Messaging;

public class GameResponse
{
    public required Game Game { get; init; }

    public required List<Player> Players { get; init; }

    public required Variant Variant { get; init; }

    public required Player Button { get; init; }
}
