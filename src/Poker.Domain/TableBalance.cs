namespace Poker.Domain;

public record TableBalance
{
    public required IReadOnlyList<TableBalanceEntry> Tables { get; init; }
}
