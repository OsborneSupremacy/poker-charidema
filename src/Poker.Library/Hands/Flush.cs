using Poker.Library.Cards;

namespace Poker.Library.Hands;

public class Flush : IHandRanking
{
    public string Name => "Flush";

    public uint Value => 60;

    public IHandRankingResult Qualify(IDeck deck, List<ICard> playerCards)
    {
        foreach(var p in deck.CardSuitPriorities)
        {
            if (playerCards.Where(c => c.MatchesSuitOrIsWild(p)).Count() < 5) continue;

            List<ICard> handCards = playerCards
                .Where(c => c.MatchesSuitOrIsWild(p))
                .OrderBy(c => c.IsWild)
                .ThenByDescending(c => c is IStandardCard s ? s.Rank.Value : 0)
                .Take(5)
                .ToList();

            return new HandRankingResult
            {
                Qualifies = true,
                HandCards = handCards,
                Kickers = new(),
                DeadCards = playerCards.Except(handCards).ToList()
            };
        }

        return new HandRankingResult
        {
            Qualifies = false,
            HandCards = new(),
            Kickers = new(),
            DeadCards = new()
        };
    }    
}
