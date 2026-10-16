using Poker.Domain.Classic.Hands;
using Poker.Domain.Functions.Classic;

namespace Poker.Domain.Functions;

public static class DefaultBestHandEvaluator
{
    public static readonly BestHandEvaluator Evaluate = request => request
        .HandCollectionEvaluator(new EvaluateHandCollectionRequest
        {
            Participant = request.Participant,
            Cards = request.Participant.CardsInPlay.ToCards(),
            HandEvaluator = request.HandEvaluator,
            HandsToEvaluate = AllHands.All,
            RemainingCardCount = request.RemainingCardCount
        })
        .Where(x => x.HandQualification == HandQualifications.Qualifies)
        .OrderByDescending(x => x.ToPlayerHand(), ClassicHandComparer.Comparer)
        .First();
}
