namespace Poker.Domain.Messaging;

public record MatchResponse
{
    public required bool Cancelled { get; init; }

    public required Match Match { get; init; }

    public required IReadOnlyList<Player> Winners { get; init; }

    public required bool PlayAgain { get; init; }
}

public static class MatchResponses
{
    public static MatchResponse Empty { get; } = new()
    {
        Cancelled = false,
        Match = new()
        {
            FixedNumberOfGames = 0,
            FixedVariant = Implementations.Variants.EmptyVariant.GetVariant(),
            FixedDeck = Decks.Empty,
            Players = [],
            Games = [],
            AntePreferences = new()
            {
                Min = 0,
                Max = 0,
                Fixed = 0,
                AnteType = AnteTypes.Empty
            },
            StartingStack = 0,
            TotalMoneyInPlay = 0
        },
        Winners = [],
        PlayAgain = true
    };
}
