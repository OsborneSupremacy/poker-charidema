namespace Poker.Library.Interface;

public interface IHandRankingResult
{
    public bool Qualifies { get; }

    public List<ICard> HandCards { get; }

    public List<ICard> Kickers { get; }

    public List<ICard> DeadCards { get; }
}
