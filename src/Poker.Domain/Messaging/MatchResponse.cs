namespace Poker.Domain.Messaging;

public record MatchResponse
{
    public required bool Cancelled { get; init; }

    public required Match Match { get; init; }

    public required List<Participant> Winners { get; init; }

    public required bool PlayAgain { get; init; }
}
