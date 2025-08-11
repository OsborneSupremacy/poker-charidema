namespace Poker.Domain;

public record LedgerStatusResponse
{
    public required List<LedgerEntry> LedgerEntries { get; init; }

    public required int Balance { get; init; }
}
