namespace Poker.Domain.Messaging;

public record TableBalanceUpdateRequest
{
    public required Guid PlayerId { get; init; }

    public required int Credit { get; init; }

    public required int Debit { get; init; }

    public required TableBalanceEntryType Type { get; init; }
}
