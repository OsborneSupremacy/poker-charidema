namespace Poker.Library.Interface;

public interface IPlayer
{
    Guid Id { get; }

    string Name { get; }

    double BeginningStack { get; }

    double Stack { get; }

    public bool Automaton { get; set; }
}
