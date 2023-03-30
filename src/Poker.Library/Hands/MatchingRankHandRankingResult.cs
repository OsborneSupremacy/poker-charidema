﻿using Poker.Library.Cards;

namespace Poker.Library.Hands;

public abstract class MatchingRankHandRankingResult
{
    public abstract string Name { get; }

    public abstract uint Value { get; }

    public abstract int RequiredMatches { get; }

    public IPartialHandRankingResult QualifyPartial(IDeck deck, List<ICard> playerCards)
    {
        var (qualifies, qualifyingRank) = GetQualifyingRank(deck, playerCards);

        if (!qualifies) return new PartialHandRankingResult()
        {
            Qualifies = false,
            HandCards = new(),
            NonHandCards = new()
        };

        var handCards = playerCards.GetMatchingRankOrWild(qualifyingRank);

        return new PartialHandRankingResult()
        {
            Qualifies = true,
            HandCards = handCards,
            NonHandCards = playerCards.Except(handCards).ToList()
        };
    }

    public IHandRankingResult Qualify(IDeck deck, List<ICard> playerCards)
    {
        var (qualifies, qualifyingRank) = GetQualifyingRank(deck, playerCards);

        if (!qualifies) return new HandRankingResult
        {
            Qualifies = false,
            HandCards = new(),
            Kickers = new(),
            DeadCards = new()
        };

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
