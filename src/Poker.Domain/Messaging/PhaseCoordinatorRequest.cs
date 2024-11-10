namespace Poker.Domain.Messaging;

public record PhaseCoordinatorRequest
{
    public required Game Game { get; init; }

    public required Phase Phase { get; init; }

    public required Deck Deck { get; init; }
}
