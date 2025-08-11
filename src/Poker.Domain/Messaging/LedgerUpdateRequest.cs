namespace Poker.Domain.Messaging;

public record LedgerUpdateRequest
{
    public required Guid PlayerId { get; init; }

    public required int Credit { get; init; }

    public required int Debit { get; init; }

    public required LedgerEntryType LedgerEntryType { get; init; }
}
