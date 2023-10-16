namespace Poker.Service;

public record PlayerCreateArgs
{
    public required Guid Id { get; init; }

    public required int BeginningStack { get; init; }

    public required bool Automaton { get; set; }
}
