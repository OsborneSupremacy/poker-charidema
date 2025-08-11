namespace Poker.Domain;

public record LedgerEntry
{
    public required Guid Id { get; init; }

    public required DateTimeOffset Timestamp { get; init; }

    public required Guid PlayerId { get; init; }

    public int Credit { get; init; }

    public int Debit { get; init; }
}

public enum LedgerEntryType
{
    InitialBalance,
    Ante,
    Bet,
    PayOut,
}
