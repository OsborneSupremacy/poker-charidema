namespace Poker.Library.Hands;

public class Flush : IHandRanking
{
    public string Name => "Flush";

    public uint Value => 60;

    public IHandRankingResult Qualify(IHandRankingArgs args)
    {
        var deck = args.Deck;
        var playerCards = args.PlayerCards;

        foreach (var p in deck.CardSuitPriorities)
        {
            if (playerCards.Where(c => c.MatchesSuitOrIsWild(p)).Count() < 5) continue;

            var handCards = playerCards
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

        return new NoHand().Qualify(args);
    }
}
