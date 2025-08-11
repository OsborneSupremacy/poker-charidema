namespace Poker.Domain;

public record Ledger
{
    public required IReadOnlyList<LedgerEntry> LedgerEntries { get; init; }
}
