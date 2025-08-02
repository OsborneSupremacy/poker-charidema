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
        var kickerRanks = playerBestHands
            .SelectMany(x => x.Kickers.Select(k => k.Rank))
            .Distinct()
            .ToList();

        var finalists = playerBestHands;

        foreach (
            Rank kickerRank in kickerRanks
                .OrderByDescending(r => r.Value)
            )
        {
            finalists = playerBestHands
                .Where
                (
                    x => x.Kickers
                        .Any(k => k.Rank == kickerRank)
                )
                .ToList();

            if (finalists.Count == 1)
                break;
        }

        return finalists
            .Select(x => x.Participant)
            .ToList();
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
