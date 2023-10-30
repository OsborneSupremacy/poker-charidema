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
            PlayerHands = playerBestHands,
            WinningHand = overallBestHand
        };
    };

    private static IEnumerable<PlayerHand> GetPlayerBestHands(EvaluateWinnerRequest request) =>
        request
            .Game
            .Players
            .Where(p => !p.Folded)
            .Select(
                player =>
                    DefaultBestHandEvaluator.Evaluate
                    (
                        new BestHandRequest
                        {
                            Player = player,
                            RemainingCardCount = 0,
                            HandCollectionEvaluator = DefaultHandCollectionEvaluator.Evaluate,
                            HandEvaluator = ClassicHandEvaluator.Evaluate
                        }
                    ).ToPlayerHand()
            );
    
    private static Hand GetOverallBestHand(IEnumerable<PlayerHand> playerBestHands) =>
        playerBestHands
            .OrderByDescending(x => x.Hand.HandDefinition.Value)
            .ThenByDescending(x => x.Hand.HighRank.Value)
            .Select(x => x.Hand)
            .First();

    private static List<Player> GetPlayersWithBestKickers(
        List<PlayerHand> playerHands,
        List<Player> playersWithBestHand
        )
    {
        // there's a tie. Evaluate kickers.
        var kickerRanks = playerHands
            .SelectMany(x => x.Kickers.Select(k => k.Rank))
            .Distinct()
            .ToList();
        
        // if there are no kickers (which will be the case with 5-card hands)
        // tie is unbreakable.
        if (!kickerRanks.Any())
            return playersWithBestHand;
        
        var finalists = playerHands;
        
        foreach(
            Rank kickerRank in kickerRanks
                .OrderByDescending(r => r.Value)
            )
        {
            finalists = playerHands
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
            .Select(x => x.Player)
            .ToList();
    }

    private static List<Player> GetPlayersWithBestHandIncludingKickers(
        List<PlayerHand> playerBestHands,
        Hand overallBestHand
        )
    {
        var playersWithBestHand = playerBestHands
            .Where(x => x.Hand == overallBestHand)
            .Select(x => x.Player)
            .ToList();

        return playersWithBestHand.Count == 1
            ? playersWithBestHand
            : GetPlayersWithBestKickers(playerBestHands, playersWithBestHand);
    }
}
