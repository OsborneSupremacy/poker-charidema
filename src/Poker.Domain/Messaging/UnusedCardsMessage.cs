namespace Poker.Domain.Messaging;

public record UnusedCardsMessage
{
    public UnusedCardsMessage() { }

    [SetsRequiredMembers]
    public UnusedCardsMessage(IReadOnlyCollection<Card> cards)
    {
        UnusedStandard = cards
            .Standard()
            .ToList();

        UnusedWild = cards
            .Wild()
            .ToQueue();
    }

    public required List<Card> UnusedStandard { get; init; }

    public required Queue<Card> UnusedWild { get; init; }
}

