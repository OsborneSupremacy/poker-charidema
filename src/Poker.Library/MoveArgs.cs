using Poker.Library.Phases;

namespace Poker.Library;

public record MoveArgs
{
    public required Player PlayerInTurn { get; init; }

    public required PhaseArgs RoundArgs { get; init; }

    public required uint Pot { get; init; }
}
