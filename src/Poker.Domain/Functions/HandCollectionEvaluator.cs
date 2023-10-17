namespace Poker.Domain.Functions;

internal static class HandCollectionEvaluator
{
    public static IEnumerable<EvaluatedHandResponse> Evaluate(
        EvaluatedHandCollectionRequest request
        )
    {
        foreach (var hand in request.HandsToEvaluate
            .OrderByDescending(h => h.HandDefinition.Value)
            .ThenByDescending(h => h.HighRank.Value)
            .ThenByDescending(h => h.Suit.Priority)
            )
            yield return request.HandEvaluator(new EvaluatedHandRequest
            {
                Cards = request.Cards,
                HandToEvaluate = hand,
                RemainingCardCount = request.RemainingCardCount
            });
    }
}
