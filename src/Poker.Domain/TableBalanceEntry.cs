namespace Poker.Domain;

public record TableBalanceEntry
{
    public required Guid Id { get; init; }

    public required DateTime Timestamp { get; init; }

    public required Guid PlayerId { get; init; }

    public int Credit { get; init; }

    public int Debit { get; init; }
}

public enum TableBalanceEntryType
{
    Ante,
    Bet,
    PayOut
}
