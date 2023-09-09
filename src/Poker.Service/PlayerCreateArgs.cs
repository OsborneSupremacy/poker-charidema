namespace Poker.Service;

public record PlayerCreateArgs
{
    public required Guid Id { get; init; }

    public required uint BeginningStack { get; init; }

    public required bool Automaton { get; set; }
}
