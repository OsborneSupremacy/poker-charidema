namespace Poker.Library.AntePreferences;

public record Fixed : IAntePreferences
{
    public required uint Amount { get; init; }
}
