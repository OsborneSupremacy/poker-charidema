﻿namespace Poker.Domain.Functions.Classic;

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
                            HandCollectionEvaluator = request.HandCollectionEvaluator,
                            HandEvaluator = request.HandEvaluator
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
        List<PlayerHand> playerBestHands
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
            .ToList();

        return (playersWithBestHand.Count == 1 || overallBestHand.IsFiveCardHand())
            ? playersWithBestHand.Select(x => x.Player).ToList()
            : GetPlayersWithBestKickers(playersWithBestHand);
    }
}
