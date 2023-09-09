using System.Runtime.CompilerServices;

namespace Poker.Library;

public record Player : IPlayer
{
    public required Guid Id { get; init; }

    public required string Name { get; init; }

    public required uint BeginningStack { get; init; }

    public required uint Stack { get; init; }

    public required bool Automaton { get; init; }

    public required bool Busted { get; init; }
}
