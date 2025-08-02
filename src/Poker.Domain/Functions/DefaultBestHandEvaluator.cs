using Poker.Domain.Classic.Hands;

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
        .First(x => x.HandQualification == HandQualifications.Qualifies);
}
