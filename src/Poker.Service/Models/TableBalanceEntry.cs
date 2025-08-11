namespace Poker.Service.Models;

internal record TableBalanceEntry
{
    public required Guid Id { get; init; }

    public required DateTime Timestamp { get; init; }

    public required Guid ParticipantId { get; init; }

    public required int Credit { get; init; }

    public required int Debit { get; init; }

    public required TableBalanceEntryType TableBalanceEntryType { get; init; }
}

internal enum TableBalanceEntryType
{
    Ante,
    Bet,
    PayOut
}
