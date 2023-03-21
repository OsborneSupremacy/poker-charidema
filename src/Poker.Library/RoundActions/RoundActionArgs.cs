
namespace Poker.Library.RoundActions;

public record RoundActionArgs
{
    public RoundAction RoundAction { get; init; }

    public Deck Deck { get; init; }

    public List<Player> Players { get; init; }
}
