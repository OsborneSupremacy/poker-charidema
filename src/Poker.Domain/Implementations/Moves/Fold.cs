namespace Poker.Domain.Implementations.Moves;

public record Fold : IMove
{
    public string ImperativeName => "Fold";

    public string DescriptiveName => "folds";
}
