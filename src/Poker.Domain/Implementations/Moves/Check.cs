namespace Poker.Domain.Implementations;

public record Check : IWageringMove
{
    public string ImperativeName => "Check";

    public string DescriptiveName => "checks";
}
