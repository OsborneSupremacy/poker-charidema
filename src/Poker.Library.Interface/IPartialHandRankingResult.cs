namespace Poker.Library.Interface;

public interface IPartialHandRankingResult
{
    bool Qualifies { get; }

    List<ICard> HandCards { get; }

    List<ICard> NonHandCards { get; }
}
