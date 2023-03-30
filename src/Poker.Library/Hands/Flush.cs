using Poker.Library.Cards;

namespace Poker.Library.Hands;

public class Flush : IHandRanking
{
    public string Name => "Flush";

    public uint Value => 60;

    public IHandRankingResult Qualify(IDeck deck, List<ICard> playerCards)
    {
        throw new NotImplementedException();
    }
    
    public IPartialHandRankingResult QualifyPartial(IDeck deck, List<ICard> playerCards) => throw new NotImplementedException();
}
