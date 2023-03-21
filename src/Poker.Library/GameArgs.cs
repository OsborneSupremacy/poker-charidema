using static Poker.Library.Match;

namespace Poker.Library;

public record GameArgs
{
    public List<Player> Players { get; init; }

    public MatchTypes MatchType { get; init; }

    public Variant Variant { get; init; }

    public Deck Deck { get; init; }

    public Player Button { get; init; }
}
