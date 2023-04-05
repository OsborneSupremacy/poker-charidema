namespace Poker.Library;

public record MatchResult
{
    public required bool Cancelled { get; init; }

    public required Match Match { get; init; }

    public required List<IPlayer> Winners { get; init; }

    public required bool PlayAgain { get; init; }
}
