namespace Poker.Library;

public record Match
{
    public enum MatchTypes
    {
        Dealer,
        Button
    }

    public MatchTypes MatchType { get; init; }

    public List<Player> Players { get; init; }

    public List<Game> Games { get; init; }
}
