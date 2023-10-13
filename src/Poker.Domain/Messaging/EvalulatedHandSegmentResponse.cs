namespace Poker.Domain.Messaging;

public record EvalulatedHandSegmentResponse
{
    public required bool MeetsRequirements { get; init; }

    public required HandCards Contributing { get; init; }

    /// <summary>
    /// A <see cref="HandSegment"/> representing the cards that are still needed
    /// to meet the requirements of the requested HandSegment.
    /// </summary>
    public required HandSegment Outstanding { get; init; }

    public required UnusedCardsMessage UnusedCards { get; init; }
}
