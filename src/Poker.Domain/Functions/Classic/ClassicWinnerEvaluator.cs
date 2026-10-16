namespace Poker.Domain.Functions.Classic;

public static class ClassicWinnerEvaluator
{
    public static readonly WinnerEvaluator Evaluate = request =>
    {
        var playerBestHands = GetPlayerBestHands(request).ToList();
        var overallBestHand = GetOverallBestHand(playerBestHands);
        var winners = GetPlayersWithBestHandIncludingKickers(playerBestHands, overallBestHand);

        return new EvaluateWinnerResponse
        {
            Winners = winners,
            ParticipantHands = playerBestHands,
            WinningHand = overallBestHand
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

    private static Hand GetOverallBestHand(IEnumerable<ParticipantHand> playerBestHands) =>
        playerBestHands
            .OrderByDescending(x => x.Hand.HandDefinition.Value)
            .ThenByDescending(x => x.Hand.HighRank.Value)
            .Select(x => x.Hand)
            .First();

    private static List<Participant> GetPlayersWithBestKickers(
        List<ParticipantHand> playerBestHands
        )
    {
        var bestKickerRankValues = playerBestHands
            .Select(GetKickerRankValues)
            .Aggregate((best, next) => CompareKickerRankValues(next, best) > 0 ? next : best);

        return playerBestHands
            .Where(x => CompareKickerRankValues(GetKickerRankValues(x), bestKickerRankValues) == 0)
            .Select(x => x.Participant)
            .ToList();
    }

    private static List<int> GetKickerRankValues(ParticipantHand playerHand) =>
        playerHand.Kickers
            .Select(k => k.Rank.Value)
            .OrderDescending()
            .ToList();

    /// <summary>
    /// Compares kickers from highest to lowest. The first pair of kickers that differ
    /// decides; if all compared kickers are equal, having more kickers wins.
    /// </summary>
    private static int CompareKickerRankValues(List<int> x, List<int> y)
    {
        var firstDifference = x
            .Zip(y, (xValue, yValue) => xValue.CompareTo(yValue))
            .FirstOrDefault(c => c != 0);

        return firstDifference != 0 ? firstDifference : x.Count.CompareTo(y.Count);
    }

    private static List<Participant> GetPlayersWithBestHandIncludingKickers(
        List<ParticipantHand> playerBestHands,
        Hand overallBestHand
        )
    {
        var playersWithBestHand = playerBestHands
            .Where(x => x.Hand == overallBestHand)
            .ToList();

        return (playersWithBestHand.Count == 1 || overallBestHand.IsFiveCardHand())
            ? playersWithBestHand.Select(x => x.Participant).ToList()
            : GetPlayersWithBestKickers(playersWithBestHand);
    }
}
