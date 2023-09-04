namespace Poker.Library.Moves;

public record Draw : IMove
{
    public string ImperativeName => "Draw";

    public string DescriptiveName => "draws";
}
