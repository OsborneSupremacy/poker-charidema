namespace Poker.Domain.Messaging;

public record MatchRequest
{
    public required Match Match { get; init; }

    public required Participant InitialButton { get; init; }
}
