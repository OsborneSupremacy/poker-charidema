namespace Poker.Service;

public class EvaluationService : IPhaseService
{
    private readonly IUserInterfaceService _userInterfaceService;

    public EvaluationService(
        IUserInterfaceService userInterfaceService
        )
    {
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
    }
    
    private record PlayerBestHand
    {
        public required Player Player { get; init; }

        public required PlayerHand PlayerHand { get; init; }
    }
    
    private static IEnumerable<PlayerBestHand> GetPlayerBestHands(PhaseRequest request) =>
        request
            .Game
            .Players
            .Where(p => !p.Folded)
            .Select(player => new PlayerBestHand()
            {
                Player = player,
                PlayerHand = DefaultBestHandEvaluator.Evaluate
                (
                    new BestHandRequest
                    {
                        Cards = player.Cards,
                        RemainingCardCount = request
                            .Game
                            .Variant
                            .GetRemainingCardCount(request.Phase.Number),
                        HandCollectionEvaluator = DefaultHandCollectionEvaluator.Evaluate,
                        HandEvaluator = ClassicHandEvaluator.Evaluate
                    }
                ).ToPlayerHand()
            });
    
    private static Hand GetOverallBestHand(List<PlayerBestHand> playerBestHands) =>
        playerBestHands
            .OrderByDescending(x => x.PlayerHand.Hand.HandDefinition.Value)
            .ThenByDescending(x => x.PlayerHand.Hand.HighRank.Value)
            .Select(x => x.PlayerHand.Hand)
            .First();

    private static List<Player> GetPlayersWithBestKickers(
        List<PlayerBestHand> playerBestHands,
        List<Player> playersWithBestHand
        )
    {
        // there's a tie. Evaluate kickers.
        var kickerRanks = playerBestHands
            .SelectMany(x => x.PlayerHand.Kickers.Select(k => k.Rank))
            .Distinct()
            .ToList();
        
        // if there are no kickers (which will be the case with 5-card hands)
        // tie is unbreakable.
        if (!kickerRanks.Any())
            return playersWithBestHand;
        
        var finalists = playerBestHands;
        
        foreach(
            Rank kickerRank in kickerRanks
                .OrderByDescending(r => r.Value)
            )
        {
            finalists = playerBestHands
                .Where
                (
                    x => x.PlayerHand
                        .Kickers
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
        List<PlayerBestHand> playerBestHands,
        Hand overallBestHand
        )
    {
        var playersWithBestHand = playerBestHands
            .Where(x => x.PlayerHand.Hand == overallBestHand)
            .Select(x => x.Player)
            .ToList();

        if (playersWithBestHand.Count == 1)
            return playersWithBestHand;
        
        return GetPlayersWithBestKickers(playerBestHands, playersWithBestHand);
    }

    public Task<PhaseResponse> ExecuteAsync(PhaseRequest request)
    {
        var playerBestHands = GetPlayerBestHands(request).ToList();
        var overallBestHand = GetOverallBestHand(playerBestHands);
        var winners = GetPlayersWithBestHandIncludingKickers(playerBestHands, overallBestHand);

        foreach (var playerBestHand in playerBestHands)
            _userInterfaceService
                .RenderCards
                (
                    playerBestHand.Player.Name,
                    playerBestHand.PlayerHand
                );

        if (winners.Count > 1)
            _userInterfaceService
                .WriteList($"Winning Hand: {overallBestHand.Name}. Winners: ", winners.Select(w => w.Name));
        else
            _userInterfaceService
                .WriteLine($"{winners.Single().Name} wins! Winning Hand: {overallBestHand.Name}!");

        return Task.FromResult(new PhaseResponse()
        {
            Deck = request.Deck,
            CommunityCards = request.CommunityCards,
            Players = request.Game.Players,
            Winners = winners,
            GameOver = true,
            Pot = request.Pot
        });
    }
}
