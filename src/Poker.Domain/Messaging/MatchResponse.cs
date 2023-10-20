namespace Poker.Domain.Messaging;

public record MatchResponse
{
    public required bool Cancelled { get; init; }

    public required Match Match { get; init; }

    public required List<Participant> Winners { get; init; }

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
            Players = new(),
            Games = new(),
            AntePreferences = new()
            {
                Min = 0,
                Max = 0,
                Fixed = 0,
                AnteType = AnteTypes.Empty
            },
            StartingStack = 0
        },
        Winners = new(),
        PlayAgain = true
    };
}
