namespace Poker.Library;

public record MatchResult : Match
{
    public List<Player> Winners { get; init; }
}
