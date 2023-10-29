using Poker.Domain.Classic.Hands;

namespace Poker.Domain.Functions;

public static class DefaultBestHandEvaluator
{
    public static readonly BestHandEvaluator Evaluate = request =>
    {
        return request
            .HandCollectionEvaluator(new EvaluatedHandCollectionRequest
            {
                Cards = request.Cards,
                HandEvaluator = request.HandEvaluator,
                HandsToEvaluate = AllHands.All,
                RemainingCardCount = request.RemainingCardCount
            })
            .First(x => x.HandQualification == HandQualifications.Qualifies);
    };
}
