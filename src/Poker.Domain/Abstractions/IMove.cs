namespace Poker.Domain.Abstractions;

public interface IMove
{
    public string ImperativeName { get; }

    public string DescriptiveName { get; }
}
