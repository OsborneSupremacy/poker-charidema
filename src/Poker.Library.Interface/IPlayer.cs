namespace Poker.Library.Interface;

public interface IPlayer
{
    Guid Id { get; }

    string Name { get; }

    uint BeginningStack { get; }

    uint Stack { get; }

    bool Automaton { get; }

    bool Busted { get; }
}
