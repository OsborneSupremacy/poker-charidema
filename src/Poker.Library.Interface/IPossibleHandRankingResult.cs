namespace Poker.Library.Interface;

public interface IPossibleHandrankingResult
{
    bool Qualifies { get; }

    List<ICard> HandCards { get; }

    List<ICard> NonHandCards { get; }
}
