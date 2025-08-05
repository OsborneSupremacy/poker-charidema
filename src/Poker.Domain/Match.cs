namespace Poker.Domain;

public record Match
{
    public required int FixedNumberOfGames { get; init; }

    public required Variant FixedVariant { get; init; }

    public required Deck FixedDeck { get; init; }

    public required IReadOnlyList<Player> Players { get; init; }

    public required IReadOnlyList<GameResponse> Games { get; init; }

    public required AntePreferences AntePreferences { get; init; }

    public required int StartingStack { get; init; }

    public required int TotalMoneyInPlay { get; init; }
}

public record AntePreferences
{
    public required int Min { get; init; }

    public required int Max { get; init; }

    public required int Fixed { get; init; }

    public required AnteTypes AnteType { get; init; }
}

public enum AnteTypes
{
    Empty,
    Fixed,
    DealersChoice
}
