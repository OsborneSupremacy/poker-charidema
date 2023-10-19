namespace Poker.Domain.Implementations.Moves;

public record Raise : IWageringMove
{
    public string ImperativeName => "Raise";

    public string DescriptiveName => "raises {amount}";
}
