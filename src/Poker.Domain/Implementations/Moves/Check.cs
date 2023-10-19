namespace Poker.Domain.Implementations.Moves;

public record Check : IWageringMove
{
    public string ImperativeName => "Check";

    public string DescriptiveName => "checks";
}
