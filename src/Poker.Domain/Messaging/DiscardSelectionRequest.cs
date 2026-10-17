namespace Poker.Domain.Messaging;

public record DiscardSelectionRequest
{
    public required Participant Participant { get; init; }

    public required Phase Phase { get; init; }
}
