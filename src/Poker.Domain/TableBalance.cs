namespace Poker.Domain;

public class TableBalance
{
    public required IReadOnlyList<TableBalanceEntry> Tables { get; init; }
}
