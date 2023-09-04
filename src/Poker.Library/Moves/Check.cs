namespace Poker.Library.Moves;

public record Check : IWageringMove
{
    public string ImperativeName => "Check";

    public string DescriptiveName => "checks";
}
