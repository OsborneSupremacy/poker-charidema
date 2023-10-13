namespace Poker.Domain.Messaging;

public record UnusedCardsMessage
{
    [SetsRequiredMembers]
    public UnusedCardsMessage(List<Card> cards)
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

