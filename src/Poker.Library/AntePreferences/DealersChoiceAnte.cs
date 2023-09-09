namespace Poker.Library.AntePreferences;

public record DealersChoiceAnte : IAntePreferences
{
    public required uint MinAnte { get; init; }

    public required uint MaxAnte { get; init; }
}
