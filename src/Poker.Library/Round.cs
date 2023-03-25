using Poker.Library.RoundActions;

namespace Poker.Library;

public record Round
{
    public required List<Bet> Bets { get; init; }

    public required IRoundAction RoundAction { get; init; }
}
