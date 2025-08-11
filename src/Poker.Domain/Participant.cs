namespace Poker.Domain;

/// <summary>
/// A player who is participating in a game. They must have at least
/// been part of the game at the start (e.g. they had some money and had
/// the option to play). Even if they don't ante, they are still considered
/// a participant.
/// </summary>
public record Participant
{
    public required Guid Id { get; init; }

    public required string Name { get; init; }

    public required int BeginningStack { get; init; }

    public required int Stack { get; init; }

    public required bool Automaton { get; init; }

    /// <summary>
    /// Participant is out of money and cannot continue playing.
    /// </summary>
    public required Func<bool> Busted { get; init; }

    /// <summary>
    /// The amount the player has contributed to the current game's pot.
    /// This may end up not being used for anything. Revisit and remove if not.
    /// </summary>
    public required Func<int> Stake { get; init; }

    public required Action<int> Pay { get; init; }

    public required bool Folded { get; init; }

    public required IReadOnlyList<CardInPlay> CardsInPlay { get; init; }
}

public static class Participants
{
    public static Participant Empty { get; } = new()
    {
        Id = Guid.Empty,
        Name = GlobalConstants.Empty,
        BeginningStack = 0,
        Stack = 0,
        Automaton = true,
        Busted = () => false,
        Stake = () => 0,
        Pay = _ => { },
        Folded = false,
        CardsInPlay = []
    };
}
