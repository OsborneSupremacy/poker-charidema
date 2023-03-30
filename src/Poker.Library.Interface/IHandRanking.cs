namespace Poker.Library.Interface;

public interface IHandRanking
{
    string Name { get; }

    uint Value { get; }

    /// <summary>
    /// Determines whether a hand qualifies as a rank, before not all cards have been dealt.
    /// </summary>
    /// <param name="deck"></param>
    /// <param name="playerCards"></param>
    /// <returns></returns>
    IPartialHandRankingResult QualifyPartial(IDeck deck, List<ICard> playerCards);

    IHandRankingResult Qualify(IDeck deck, List<ICard> playerCards);
}
