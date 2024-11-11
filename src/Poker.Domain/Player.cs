namespace Poker.Domain;

public record Player
{
    public required Guid Id { get; init; }

    public required string Name { get; init; }

    public required int BeginningStack { get; init; }

    public required int Stack { get; init; }

    public required bool Automaton { get; init; }

    public required bool Busted { get; init; }

    public required List<CardInPlay> CardsInPlay { get; init; }

    /// <summary>
    /// The amount the player has contributed to the current game's pot.
    /// This may end up not being used for anything. Revisit and remove if not.
    /// </summary>
    public required int Stake { get; init; }

    public required bool Folded { get; init; }
}

public static class Players
{
    public static Player Empty { get; } = new()
    {
        Id = Guid.Empty,
        Name = GlobalConstants.Empty,
        BeginningStack = 0,
        Stack = 0,
        Automaton = true,
        Busted = false,
        CardsInPlay = [],
        Stake = 0,
        Folded = true
    };
}
