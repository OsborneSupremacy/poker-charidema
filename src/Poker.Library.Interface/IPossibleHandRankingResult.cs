namespace Poker.Library.Interface;

public interface IPossibleHandRankingResult
{
    bool Qualifies { get; }

    List<ICard> HandCards { get; }

    List<ICard> NonHandCards { get; }
}
