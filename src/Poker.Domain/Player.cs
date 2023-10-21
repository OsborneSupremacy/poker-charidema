namespace Poker.Domain;

public record Player
{
    public required Guid Id { get; init; }

    public required string Name { get; init; }

    public required int BeginningStack { get; init; }

    public required int Stack { get; init; }

    public required bool Automaton { get; init; }

    public required bool Busted { get; init; } 

    public required List<Card> Cards { get; init; }

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
        Cards = new(),
        Folded = true
    };
}
