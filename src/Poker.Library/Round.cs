using Poker.Library.RoundActions;

namespace Poker.Library;

public record Round
{
    public List<Bet> Bets { get; init; }

    public RoundAction RoundAction { get; init; }
}
