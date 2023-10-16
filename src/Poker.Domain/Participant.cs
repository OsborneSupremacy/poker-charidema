namespace Poker.Domain;

public record Participant
{
    public required Guid Id { get; init; }

    public required string Name { get; init; }

    public required int BeginningStack { get; init; }

    public required int Stack { get; set; }

    public required bool Automaton { get; init; }

    public required bool Busted { get; init; }
}
