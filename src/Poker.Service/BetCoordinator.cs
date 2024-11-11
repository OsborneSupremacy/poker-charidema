namespace Poker.Service;

public class BetCoordinator : IPhaseService
{
    private readonly IUserInterfaceService _userInterfaceService;

    private readonly IBettingIntervalService _bettingIntervalService;

    private readonly ILeadPlayerService  _leadPlayerService;

    public BetCoordinator(
        IUserInterfaceService userInterfaceService,
        IBettingIntervalService bettingIntervalService,
        ILeadPlayerService leadPlayerService
        )
    {
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
        _bettingIntervalService =
            bettingIntervalService ?? throw new ArgumentNullException(nameof(bettingIntervalService));
        _leadPlayerService = leadPlayerService ?? throw new ArgumentNullException(nameof(leadPlayerService));
    }

    private async Task<Player> GetCurrentBettorAsync(PhaseRequest request)
    {
        var anyFaceUpCards = request.Game.Players
            .SelectMany(p => p.CardsInPlay)
            .FaceUp()
            .Any();

        if (!anyFaceUpCards)
            return request.StartingPlayer;

        var leadPlayerResponse = await _leadPlayerService.ExecuteAsync(
            new EvaluateLeadPlayerRequest
            {
                CommunityCards = request.CommunityCards,
                Players = request.Game.Players
            }
        );

        if (leadPlayerResponse.LeadPlayers.Count > 1)
        {
            _userInterfaceService.WriteLine($"Multiple players have the best hand showing, with {leadPlayerResponse.LeadingHand.Name}.");
            _userInterfaceService.WriteLine("The tie goes to the player closest to the dealer.");
            return leadPlayerResponse.LeadPlayers.First();
        }

        var leadPlayer = leadPlayerResponse.LeadPlayers.First();
        _userInterfaceService.WriteLine($"{leadPlayer.Name} has the best hand showing with {leadPlayerResponse.LeadingHand.Name}.");
        return leadPlayer;
    }

    public async Task<PhaseResponse> ExecuteAsync(PhaseRequest request)
    {
        var currentBettor = await GetCurrentBettorAsync(request);
        _userInterfaceService.WriteLine($"{currentBettor.Name} bets.");


        PhaseResponse response = new()
        {
            Deck = request.Deck,
            CommunityCards = request.CommunityCards,
            Players = request.Game.Players,
            Winners = [],
            GameOver = false,
            Pot = request.Pot
        };

        return response;
    }
}
