﻿namespace Poker.Domain.Extensions;

public static class CardCollectionExtensions
{
    public static List<Card> GetMatchingRankHand(
        this List<Card> input,
        Rank rank,
        int requiredCount
    ) =>
        input.AnyWild() switch
        {
            true => input.GetMatchingRankHandWithSomeWildCards(rank, requiredCount),
            false => input.GetMatchingRankHandWithNoWildCards(rank, requiredCount),
        };

    public static List<Card> GetMatchingRankHandWithNoWildCards(
        this List<Card> input,
        Rank rank,
        int requiredCount
        ) => input
            .WhereRank(rank)
            .OrderBySuit()
            .Take(requiredCount)
            .ToList();

    public static List<Card> GetMatchingRankHandWithSomeWildCards(
        this List<Card> input,
        Rank rank,
        int requiredCount
        )
    {
        Queue<Card> wildCards = input.WhereWild().ToQueue();

        var cardsWithRank = input.WhereRank(rank).ToList();
        var neededCount = requiredCount - cardsWithRank.Count;

        // add non-wildcards matching rank
        var cardsOut = cardsWithRank
            .OrderBySuit()
            .Take(requiredCount)
            .ToList();

        // cards that can be impersonated, with rank in question
        var targets = Cards
            .All
            .WhereRank(rank)
            .Except(cardsWithRank)
            .OrderBySuit()
            .Take(neededCount)
            .ToQueue();

        // exception for 5-of-a-kind only. Allow cards in the player's
        // hand to be impersonated. Otherwise, there's no way to get 5-of-a-kind
        if (targets.Count < neededCount)
            targets = Cards
                .All
                .WhereRank(rank)
                .OrderBySuit()
                .Take(neededCount)
                .ToQueue();

        while (
            targets.Any()
            && wildCards.Any()
            && cardsOut.Count < requiredCount
            )
            cardsOut.Add(
                wildCards.Dequeue() with { Impersonating = targets.Dequeue() }
            );

        return cardsOut;
    }

    public static List<Card> GetKickers(
        this List<Card> input,
        List<Card> handCards) =>
            input
                .WithoutImpersonation()
                .Except(handCards.WithoutImpersonation())
                .OrderByPokerStandard()
                .Take(GlobalConstants.HandSize - handCards.Count)
                .ToList();

    public static List<Card> GetDeadCards(
        this List<Card> input,
        List<Card> handCards,
        List<Card> kickers
        ) =>
        input.WithoutImpersonation()
            .Except(handCards.WithoutImpersonation())
            .Except(kickers.WithoutImpersonation())
            .ToList();

    public static bool HasCountOfMatchingRank(this List<Card> input, Rank rank, uint count) =>
        input.WhereRank(rank).Count() >= count;

    public static bool HasCountOfMatchingRankOrWild(this List<Card> input, Rank rank, uint count) =>
        input.WhereRanksOrIsWild(rank).Count() >= count;

    public static bool AnyWild(this List<Card> input) =>
        input.WhereWild().Any();

    public static int WildCount(this List<Card> input) =>
        input.WhereWild().Count();

    public static Rank GetBestMatchingRank(this List<Card> cards, uint count)
    {
        foreach (var rank in Ranks.All.OrderByPokerStandard())
            if (cards.HasCountOfMatchingRankOrWild(rank, count))
                return rank;
        return Ranks.Empty;
    }

    public static Rank GetMaxRank(this IEnumerable<Card> input)
    {
        var cards = input.ToList();
        return cards.Any() switch
        {
            true => cards
                .Where(c => c.Rank.Value == cards.Max(c => c.Rank.Value))
                .Select(c => c.Rank)
                .First(),
            false => Ranks.Empty
        };
    }

    public static string AggregateId(this List<Card> input) =>
        string.Join('|',
            input.OrderBy(x => x.Id).Select(x => x.Id.ToString())
        );
}