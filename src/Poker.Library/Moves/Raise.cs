namespace Poker.Library.Moves;

public record Raise : IWageringMove
{
    public string ImperativeName => "Raise";

    public string DescriptiveName => "raises {amount}";
}
