namespace Poker.Domain;

/// <summary>
/// A player that is part of the Poker match. They may not be part of every
/// individual game (e.g. they may have run out of money), but they are still
/// considered a player in the match for the sake of tracking and reporting.
/// </summary>
public record Player
{
    public required Guid Id { get; init; }

    public required string Name { get; init; }

    public required Func<int> BeginningStack { get; init; }

    public required Func<int> Stack { get; init; }

    public required bool Automaton { get; init; }

    /// <summary>
    /// Participant is out of money and cannot continue playing.
    /// </summary>
    public required Func<bool> Busted { get; init; }
}

public static class Players
{
    public static Player Empty { get; } = new()
    {
        Id = Guid.Empty,
        Name = GlobalConstants.Empty,
        BeginningStack = () => 0,
        Stack = () => 0,
        Automaton = true,
        Busted = () => false
    };
}
