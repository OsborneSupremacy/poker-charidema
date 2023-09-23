namespace Poker.Domain.Implementations;

public record Call : IWageringMove
{
    public string ImperativeName => "Call";

    public string DescriptiveName => "calls";
}
