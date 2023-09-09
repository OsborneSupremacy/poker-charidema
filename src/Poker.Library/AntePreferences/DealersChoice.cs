namespace Poker.Library.AntePreferences;

public record DealersChoice : IAntePreferences
{
    public required uint MinAnte { get; init; }

    public required uint MaxAnte { get; init; }
}
