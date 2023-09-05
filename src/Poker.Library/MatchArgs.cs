namespace Poker.Library;

public record class MatchArgs
{
    public required List<IPlayer> Players { get; init; }

    public required IPlayer InitialButton { get; init; }

    public required uint? FixedAnte { get; init; }

    public required uint? FixedNumberOfGames { get; init; }

    public required IDeck? FixedDeck { get; init; }

    public required IVariant? FixedVariant { get; init; }

    public required uint StartingStack { get; init; }
}
