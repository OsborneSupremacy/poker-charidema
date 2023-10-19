namespace Poker.Domain.Implementations.Moves;

public record AllIn : IWageringMove
{
    public string ImperativeName => "Go All In";

    public string DescriptiveName => "goes All In";
}
