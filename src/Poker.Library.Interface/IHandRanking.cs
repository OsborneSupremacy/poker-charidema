using Poker.Library.Interface;

public interface IHandRanking
{
    string Name { get; }

    uint Value { get; }

    public IHandRankingResult Qualify(IDeck deck, List<ICard> playerCards);
}
