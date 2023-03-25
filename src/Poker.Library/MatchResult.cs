namespace Poker.Library;

public record MatchResult
{
    public required Match Match { get; init; }

    public required List<Player> Winners { get; init; }
}
