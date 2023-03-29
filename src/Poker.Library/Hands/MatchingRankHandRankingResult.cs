using Poker.Library.Cards;

namespace Poker.Library.Hands;

public abstract class MatchingRankHandRankingResult
{
    public abstract string Name { get; }

    public abstract uint Value { get; }

    public abstract int RequiredMatches { get; }

    public IHandRankingResult Qualify(IDeck deck, List<ICard> playerCards)
    {
        foreach (var v in deck
            .CardRankValues
            .OrderByDescending(x => x)
            )
        {
            if (!playerCards.HasCountOfMatchingRankOrWild(v, RequiredMatches))
                continue;

            var handCards = playerCards.GetMatchingRankOrWild(v);
            var kickers = playerCards.GetKickers(handCards, 5);

            return new HandRankingResult
            {
                Qualifies = true,
                HandCards = handCards,
                Kickers = kickers,
                DeadCards = playerCards.GetDeadCards(handCards, kickers)
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
