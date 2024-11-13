namespace Poker.Service.Messaging;

public record PlayerCreateRequest
{
    public required Guid Id { get; init; }

    public required int BeginningStack { get; init; }

    public required bool Automaton { get; init; }
}
