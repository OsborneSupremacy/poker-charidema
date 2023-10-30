namespace Poker.Service;

public class WinnerEvaluationService : IPhaseService
{
    private readonly IUserInterfaceService _userInterfaceService;

    public WinnerEvaluationService(
        IUserInterfaceService userInterfaceService
        )
    {
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
    }
    
    public Task<PhaseResponse> ExecuteAsync(PhaseRequest request)
    {
        var response = ClassicWinnerEvaluator
            .Evaluate(new()
            {
                Game = request.Game
            });
        
            foreach (var playerHand in response.PlayerHands)
                _userInterfaceService
                    .RenderCards
                    (
                        playerHand.Player.Name,
                        playerHand
                    );
        
            var label = response.Winners.Count > 1 ? "Winners" : "Winner";

            var messages = response.Winners.Select(w => w.Name).ToList();
            messages.Add($"with {response.WinningHand.Name}");
        
            _userInterfaceService
                .WriteList(label, messages);

            var playersOut = DefaultWinningsDistributor
                .Distribute
                (
                    new()
                    {
                        Players = request.Game.Players,
                        Winners = response.Winners,
                        Pot = request.Pot
                    }
                )
                .Players;

        return Task.FromResult(new PhaseResponse()
        {
            Deck = request.Deck,
            CommunityCards = request.CommunityCards,
            Players = playersOut,
            Winners = response.Winners,
            GameOver = true,
            Pot = request.Pot
        });
    }
}
