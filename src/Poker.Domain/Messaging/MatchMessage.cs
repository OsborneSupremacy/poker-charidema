namespace Poker.Domain.Messaging;

public record MatchMessage
{
    public required bool Cancelled { get; init; }

    public required Match Match { get; init; }

    public required GameResponse? GameResponse { get; init; }
}
