namespace Poker.Service.Models;

internal record LedgerEntry
{
    public required Guid Id { get; init; }

    public required DateTimeOffset Timestamp { get; init; }

    public required Guid PlayerId { get; init; }

    public required int Credit { get; init; }

    public required int Debit { get; init; }

    public required LedgerEntryType LedgerEntryType { get; init; }
}

internal enum LedgerEntryType
{
    InitialBalance,
    Ante,
    Bet,
    PayOut
}

