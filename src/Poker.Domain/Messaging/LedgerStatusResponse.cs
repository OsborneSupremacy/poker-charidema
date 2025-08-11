namespace Poker.Domain.Messaging;

public record LedgerStatusResponse
{
    public required List<LedgerEntry> LedgerEntries { get; init; }

    public required int Balance { get; init; }
}
