namespace Poker.Domain.Functions;

public static class DefaultLedgerUpdater
{
    public static readonly LedgerUpdater Update = (ledger, request) =>
    {
        var entriesOut = ledger.LedgerEntries.ToList();
        entriesOut.Add(new LedgerEntry
        {
            PlayerId = request.PlayerId,
            Credit = request.Credit,
            Debit = request.Debit,
            LedgerEntryType = request.LedgerEntryType,
            Id = Guid.NewGuid(),
            Timestamp = DateTime.UtcNow
        });
        return new Ledger { LedgerEntries = entriesOut };
    };
}
