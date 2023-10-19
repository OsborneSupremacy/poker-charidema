namespace Poker.Domain.Implementations.Moves;

public record Draw : IMove
{
    public string ImperativeName => "Draw";

    public string DescriptiveName => "draws";
}
