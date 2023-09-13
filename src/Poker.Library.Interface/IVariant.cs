namespace Poker.Library.Interface;

public interface IVariant
{
    string Name { get; }

    List<IPhase> Phases { get; }
}
