namespace Poker.Domain.Messaging;

public class GameResponse
{
    public required Match Match { get; init; }

    public required List<Participant> Players { get; init; }

    public required Variant Variant { get; init; }

    public required Participant Button { get; init; }
}
