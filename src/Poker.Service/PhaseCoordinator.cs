namespace Poker.Service;

public class PhaseCoordinator : IPhaseCoordinator
{
    private readonly IPhaseService _phaseService;

    private readonly IUserInterfaceService _userInterfaceService;

    public PhaseCoordinator(
        IPhaseService phaseService,
        IUserInterfaceService userInterfaceService
        )
    {
        _phaseService = phaseService ?? throw new ArgumentNullException(nameof(phaseService));
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
    }

    public async Task<PhaseCoordinatorResponse> ExecuteAsync(
        PhaseCoordinatorRequest request
        )
    {
        var startingPlayer = request.Game
            .Players
            .NextPlayer
            (
                request.Game.Button
            );
        
        var phaseResponse = await _phaseService
            .ExecuteAsync(new PhaseRequest
            {
                Game = request.Game,
                Phase = request.Phase,
                Deck = request.Deck,
                CommunityCards = new(),
                StartingPlayer = startingPlayer,
                Pot = request.Game.Pot
            });

        var gameOut = request.Game with
        {
            Deck = phaseResponse.Deck,
            CommunityCards = phaseResponse.CommunityCards,
            Players = phaseResponse.Players,
            Pot = phaseResponse.Pot
        };

        if (!phaseResponse.GameOver)
        {
            _userInterfaceService
                .WriteLine()
                .WriteLine($"Pot: {gameOut.Pot:C}");
        
            RenderPlayerCards(
                phaseResponse.Players.Single(x => !x.Automaton),
                request.Game.Variant.GetRemainingCardCount(request.Phase.Number)
            );
        }

        return new PhaseCoordinatorResponse
        {
            PhaseResponse = phaseResponse,
            GameResponse = new GameResponse
            {
                Game = gameOut,
                Players = phaseResponse.Players,
                Variant = gameOut.Variant,
                Button = gameOut.Button              
            }
        };
    }

    private void RenderPlayerCards(Player player, int remainingCardCount)
    {
        if (!player.Cards.Any())
            return;

        var bestHand = DefaultBestHandEvaluator.Evaluate
        (
            new BestHandRequest
            {
                Cards = player.Cards,
                RemainingCardCount = remainingCardCount,
                HandCollectionEvaluator = DefaultHandCollectionEvaluator.Evaluate,
                HandEvaluator = ClassicHandEvaluator.Evaluate
            }
        );

        var label = !player.Automaton ? "Your" : $"{player.Name}'s";
        
        _userInterfaceService
            .WriteLine()
            .RenderCards($"{label} Cards", bestHand.ToPlayerHand());
    
        _userInterfaceService.WriteLine($"{label} best hand is: {bestHand.Hand.Name}");
    }      
}
