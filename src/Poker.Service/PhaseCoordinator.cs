using Microsoft.AspNetCore.SignalR.Protocol;

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

        var user = phaseResponse.Players.Single(x => !x.Automaton);

        if(user.Cards.Any())
        {
            var bestHand = DefaultHandCollectionEvaluator.Evaluate(
                new EvaluatedHandCollectionRequest
                {
                    Cards = user.Cards,
                    HandEvaluator = ClassicHandEvaluator.Evaluate,
                    HandsToEvaluate = Domain.Classic.Hands.AllHands.All,
                    RemainingCardCount = request.Game.Variant.GetRemainingCardCount(request.Phase.Number)
                })
                .Where(x => x.HandQualification == HandQualifications.Qualifies)
                .OrderByDescending(x => x.Hand.HandDefinition.Value)
                .ThenByDescending(x => x.Hand.HighRank.Value)
                .ThenByDescending(x => x.Hand.Suit.Priority)
                .First();
            
            _userInterfaceService
                .WriteLine()
                .WriteLine($"Pot: {gameOut.Pot:C}")
                .WriteLine()
                .WriteHeading(HeadingLevel.Six, "Your Cards")
                .RenderCards(bestHand.ToPlayerHand());
        
            _userInterfaceService.WriteLine($"Your best hand is: {bestHand.Hand.Name}");           
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
}
