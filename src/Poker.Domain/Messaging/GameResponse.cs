namespace Poker.Domain.Messaging;

public class GameResponse
{
    public required Game Game { get; init; }

    public required List<Participant> Participants { get; init; }

    public required Variant Variant { get; init; }

    public required Participant Button { get; init; }
}
