namespace Poker.Service;

public record PlayerCreateArgs
{
    public required Guid Id { get; init; }

    public required double BeginningStack { get; init; }

    public required bool Automaton { get; set; }
}
