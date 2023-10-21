namespace Poker.Domain.Messaging;

public record MatchRequest
{
    public required Match Match { get; init; }

    public required Player InitialButton { get; init; }
}
