namespace Poker.Domain.Functions.Classic;

public static class ClassicWinnerEvaluator
{
    public static readonly WinnerEvaluator Evaluate = request =>
    {
        var playerBestHands = GetPlayerBestHands(request).ToList();

        var overallBestHand = playerBestHands
            .OrderDescending(ClassicHandComparer.Comparer)
            .First();

        var winners = playerBestHands
            .Where(x => ClassicHandComparer.Compare(x, overallBestHand) == 0)
            .Select(x => x.Participant)
            .ToList();

        return new EvaluateWinnerResponse
        {
            Winners = winners,
            ParticipantHands = playerBestHands,
            WinningHand = overallBestHand.Hand
        };
    };

    private static IEnumerable<ParticipantHand> GetPlayerBestHands(EvaluateWinnerRequest request) =>
        request
            .Participants
            .Where(p => !p.Folded)
            .Select(
                player =>
                    DefaultBestHandEvaluator.Evaluate
                    (
                        new BestHandRequest
                        {
                            Participant = player,
                            RemainingCardCount = 0,
                            HandCollectionEvaluator = request.HandCollectionEvaluator,
                            HandEvaluator = request.HandEvaluator
                        }
                    ).ToPlayerHand()
            );
}
