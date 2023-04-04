namespace Poker.Library;

public record Player : IPlayer
{
    public required Guid Id { get; init; }

    public required string Name { get; init; }

    public required double BeginningStack { get; init; }

    public required double Stack { get; init; }

    public required bool Automaton { get; set; }
}
