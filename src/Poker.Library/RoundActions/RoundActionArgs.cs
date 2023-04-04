
namespace Poker.Library.RoundActions;

public record RoundActionArgs
{
    public required IRoundAction RoundAction { get; init; }

    public required IDeck Deck { get; init; }

    public required List<Player> Players { get; init; }
}
