namespace Poker.Domain.Messaging;

public record class MatchRequest
{
    public required Match Match { get; init; }

    public required Participant InitialButton { get; init; }
}
