namespace Poker.Library.Moves;

public record Fold : IMove
{
    public string ImperativeName => "Fold";

    public string DescriptiveName => "folds";
}
