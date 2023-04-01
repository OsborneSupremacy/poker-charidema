namespace Poker.Library.Interface;

/// <summary>
/// Determines whether a hand qualifies as a rank, before all cards have been dealt.
/// </summary>
public interface IPossibleHandRanking
{
    IPossibleHandrankingResult QualifyPossible(IDeck deck, List<ICard> playerCards);
}
