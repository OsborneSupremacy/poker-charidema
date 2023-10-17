﻿namespace Poker.Domain.Functions;

internal static class DefaultHandCollectionEvaluator
{
    public static HandCollectionEvaluator Evaluate = (EvaluatedHandCollectionRequest request) =>
    {
        return request.HandsToEvaluate
            .OrderByDescending(h => h.HandDefinition.Value)
            .ThenByDescending(h => h.HighRank.Value)
            .ThenByDescending(h => h.Suit.Priority)
            .Select(
                hand => request.HandEvaluator
                (
                    new EvaluatedHandRequest
                    {
                        Cards = request.Cards,
                        HandToEvaluate = hand,
                        RemainingCardCount = request.RemainingCardCount
                    }
                )
            );
    };
}