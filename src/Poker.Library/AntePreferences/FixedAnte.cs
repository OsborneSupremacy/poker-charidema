namespace Poker.Library.AntePreferences;

public record FixedAnte : IAntePreferences
{
    public required uint Amount { get; init; }
}
