namespace Poker.Service;

public class PhaseCoordinator : IPhaseCoordinator
{
    private readonly IPhaseService _phaseService;

    private readonly IUserInterfaceService _userInterfaceService;

    private readonly BestHandEvaluator _bestHandEvaluator;

    private readonly HandCollectionEvaluator _handCollectionEvaluator;

    private readonly HandEvaluator _handEvaluator;

    public PhaseCoordinator(IPhaseService phaseService, IUserInterfaceService userInterfaceService, BestHandEvaluator bestHandEvaluator, HandCollectionEvaluator handCollectionEvaluator, HandEvaluator handEvaluator)
    {
        _phaseService = phaseService;
        _userInterfaceService = userInterfaceService;
        _bestHandEvaluator = bestHandEvaluator;
        _handCollectionEvaluator = handCollectionEvaluator;
        _handEvaluator = handEvaluator;
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
                CommunityCards = [],
                StartingPlayer = startingPlayer,
                Pot = request.Game.Pot,
                GameOver = request.GameOver
            });

        var gameOut = request.Game with
        {
            Deck = phaseResponse.Deck,
            CommunityCards = phaseResponse.CommunityCards,
            Players = phaseResponse.Players,
            Pot = phaseResponse.Pot
        };

        if (phaseResponse.GameOver)
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

        _userInterfaceService
            .WriteLine()
            .WriteLine($"Pot: {gameOut.Pot:C0}");

        RenderPlayerCards(
            phaseResponse.Players.HumanPlayer(),
            request.Game.Variant.GetRemainingCardCount(request.Phase.Number)
        );

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
        if (!player.CardsInPlay.Any())
            return;

        var bestHand = _bestHandEvaluator
        (
            new BestHandRequest
            {
                Player = player,
                RemainingCardCount = remainingCardCount,
                HandCollectionEvaluator = _handCollectionEvaluator,
                HandEvaluator = _handEvaluator
            }
        );

        var label = !player.Automaton ? "Your" : $"{player.Name}'s";

        _userInterfaceService
            .WriteLine()
            .RenderCards($"{label} Cards", bestHand.ToPlayerHand());

        _userInterfaceService.WriteLine($"{label} best hand is: {bestHand.Hand.Name}");
    }
}
