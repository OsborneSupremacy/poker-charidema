using Poker.Library.Rounds;

namespace Poker.Library;

public record MoveArgs
{
    public required IInGamePlayer PlayerInTurn { get; init; }

    public required RoundArgs RoundArgs { get; init; }
}
