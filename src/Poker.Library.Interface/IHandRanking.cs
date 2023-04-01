namespace Poker.Library.Interface;

public interface IHandRanking
{
    string Name { get; }

    uint Value { get; }

    IHandRankingResult Qualify(IDeck deck, List<ICard> playerCards);
}
