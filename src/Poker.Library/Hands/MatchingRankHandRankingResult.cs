using Poker.Library.Cards;

namespace Poker.Library.Hands;

public abstract class MatchingRankHandRankingResult
{
    public abstract string Name { get; }

    public abstract uint Value { get; }

    public abstract int RequiredMatches { get; }

    public IPossibleHandrankingResult QualifyPossible(IHandRankingArgs args)
    {
        var deck = args.Deck;
        var playerCards = args.PlayerCards;

        var (qualifies, qualifyingRank) = GetQualifyingRank(deck, playerCards);

        if (!qualifies) return new PossibleRankHandingResult()
        {
            Qualifies = false,
            HandCards = new(),
            NonHandCards = new()
        };

        var handCards = playerCards.GetMatchingRankOrWild(qualifyingRank);

        return new PossibleRankHandingResult()
        {
            Qualifies = true,
            HandCards = handCards,
            NonHandCards = playerCards.Except(handCards).ToList()
        };
    }

    public IHandRankingResult Qualify(IHandRankingArgs args)
    {
        var deck = args.Deck;
        var playerCards = args.PlayerCards;

        var (qualifies, qualifyingRank) = GetQualifyingRank(deck, playerCards);

        if (!qualifies) return new NoHand().Qualify(args);

        var handCards = playerCards.GetMatchingRankOrWild(qualifyingRank);
        var kickers = playerCards.GetKickers(handCards, 5);

        return new HandRankingResult
        {
            Qualifies = true,
            HandCards = handCards,
            Kickers = kickers,
            DeadCards = playerCards.GetDeadCards(handCards, kickers)
        };
    }

    private (bool qualifies, uint qualifyingRank) GetQualifyingRank(IDeck deck, List<ICard> playerCards)
    {
        foreach (var v in deck
            .CardRankValues
            .OrderByDescending(x => x)
            )
        {
            if (!playerCards.HasCountOfMatchingRankOrWild(v, RequiredMatches))
                continue;

            return (true, v);
        }
        return (false, 0);
    }
}
