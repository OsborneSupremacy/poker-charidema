namespace Poker.Domain.Implementations;

public record AllIn : IWageringMove
{
    public string ImperativeName => "Go All In";

    public string DescriptiveName => "goes All In";
}
