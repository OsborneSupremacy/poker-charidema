namespace Poker.Library;

public record class MatchArgs
{
    public required List<Participant> Players { get; init; }

    public required Participant InitialButton { get; init; }

    public required IAntePreferences AntePreferences { get; init; }

    public required uint? FixedNumberOfGames { get; init; }

    public required IDeck? FixedDeck { get; init; }

    public required IVariant? FixedVariant { get; init; }

    public required uint StartingStack { get; init; }
}
