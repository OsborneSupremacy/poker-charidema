namespace Poker.Domain;

public class Ledger
{
    public required IReadOnlyList<LedgerEntry> LedgerEntries { get; init; }
}
