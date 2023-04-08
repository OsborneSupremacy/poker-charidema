
namespace Poker.Library.RoundActions;

public record RoundActionArgs
{
    public required IRoundAction RoundAction { get; init; }

    public required IDeck Deck { get; init; }

    public required List<IInGamePlayer> Players { get; init; }

    public required IInGamePlayer StartingPlayer { get; init; }

    public required uint RoundNumber { get; init; }
}
