namespace Poker.Domain.Implementations;

public record Draw : IMove
{
    public string ImperativeName => "Draw";

    public string DescriptiveName => "draws";
}
