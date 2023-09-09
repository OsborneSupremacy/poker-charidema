namespace Poker.Library;

public record MoveResult
{
    public required IInGamePlayer PlayerInTurn { get; init; }

    public required uint Pot { get; init; }
}
