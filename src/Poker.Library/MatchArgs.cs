namespace Poker.Library;

public record class MatchArgs
{
    public required Player InitialButton { get; init; }

    public required uint? FixedNumberOfGames { get; init; }

    public required IDeck? FixedDeck { get; init; }

    public required IVariant? FixedVariant { get; init; }
}
