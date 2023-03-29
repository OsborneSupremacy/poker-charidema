﻿namespace Poker.Library.Cards;

public static class HandExtensions
{
    public static bool HasCountOfMatchingRank(this List<ICard> input, uint rankValue, int count) =>
        input.Count(x => x.MatchesRank(rankValue)) >= count;

    public static bool HasCountOfMatchingRankOrWild(this List<ICard> input, uint rankValue, int count) =>
        input.Count(x => x.MatchesRankOrIsWild(rankValue)) >= count;

    public static List<ICard> GetMatchingRank(this List<ICard> input, uint rankValue) =>
        input.Where(x => x.MatchesRank(rankValue)).ToList();

    public static List<ICard> GetMatchingRankOrWild(this List<ICard> input, uint rankValue) =>
        input.Where(x => x.MatchesRankOrIsWild(rankValue)).ToList();

    public static List<ICard> GetKickers(this List<ICard> input, List<ICard> handCards, int handLimit)
    {
        List<ICard> nonHandCards = input
            .Except(handCards).ToList();

        List<ICard> jokers = nonHandCards
            .Where(j => j is Joker).ToList();

        List<ICard> additionalCards = nonHandCards
            .Where(c => c is Standard s)
            .OrderByDescending(c => (c as Standard)!.Rank.Value)
            .ThenByDescending(c => (c as Standard)!.Suit.Priority)
            .Take(handLimit - jokers.Count)
            .ToList();

        return jokers
            .Union(additionalCards)
            .ToList();
    }

    public static List<ICard> GetDeadCards(
        this List<ICard> input,
        List<ICard> handCards,
        List<ICard> kickers
        ) =>
        input
            .Except(handCards)
            .Except(kickers)
            .ToList();
}