namespace Poker.Domain.Implementations;

public record Fold : IMove
{
    public string ImperativeName => "Fold";

    public string DescriptiveName => "folds";
}
