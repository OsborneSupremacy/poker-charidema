namespace Poker.Domain.Functions;

public static class DefaultHandCollectionEvaluator
{
    public static readonly HandCollectionEvaluator Evaluate = request =>
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
