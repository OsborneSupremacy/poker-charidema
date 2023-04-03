namespace Poker.Library.Interface;

public interface IHandRanking
{
    string Name { get; }

    uint Value { get; }

    IHandRankingResult Qualify(IHandRankingArgs args);
}

public interface IHandRankingArgs
{
    IDeck Deck { get; }

    List<ICard> PlayerCards { get; }
}
