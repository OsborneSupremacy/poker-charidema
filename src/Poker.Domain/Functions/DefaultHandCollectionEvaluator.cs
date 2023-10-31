namespace Poker.Domain.Functions;

public static class DefaultHandCollectionEvaluator
{
    public static readonly HandCollectionEvaluator Evaluate = request => request.HandsToEvaluate
        .Select(
            hand => request.HandEvaluator
            (
                new EvaluateHandRequest
                {
                    Player = request.Player,
                    Cards = request.Cards,
                    HandToEvaluate = hand,
                    RemainingCardCount = request.RemainingCardCount
                }
            )
        )
        .OrderByDescending(h => h.Hand.HandDefinition.Value)
        .ThenByDescending(h => h.Hand.HighRank.Value)
        .ThenByDescending(h => h.Hand.Suit.Priority);
}
