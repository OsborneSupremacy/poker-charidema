namespace Poker.Domain.Messaging;

public record DiscardStrategyRequest
{
    /// <summary>
    /// The participant's best hand, which determines the cards worth keeping.
    /// </summary>
    public required ParticipantHand ParticipantHand { get; init; }

    public required Phase Phase { get; init; }
}
