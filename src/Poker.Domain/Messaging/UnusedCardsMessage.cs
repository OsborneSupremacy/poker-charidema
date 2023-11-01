namespace Poker.Domain.Messaging;

public record UnusedCardsMessage
{
    public UnusedCardsMessage() { }

    [SetsRequiredMembers]
    public UnusedCardsMessage(IReadOnlyCollection<Card> cards)
    {
        UnusedStandard = cards
            .WhereStandard()
            .ToList();

        UnusedWild = cards
            .WhereWild()
            .ToQueue();
    }

    public required List<Card> UnusedStandard { get; init; }

    public required Queue<Card> UnusedWild { get; init; }
}

