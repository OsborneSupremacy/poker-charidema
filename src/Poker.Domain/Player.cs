namespace Poker.Domain;

public record Player
{
    public required Guid Id { get; init; }

    public required string Name { get; init; }

    public required int BeginningStack { get; init; }

    public required int Stack { get; init; }

    public required bool Automaton { get; init; }

    /// <summary>
    /// Participant is out of money and cannot continue playing.
    /// </summary>
    public required bool Busted { get; init; }
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
        Busted = false
    };
}
