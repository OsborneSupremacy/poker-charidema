namespace Poker.Service;

public class BetCoordinator : IPhaseService
{
    private readonly IUserInterfaceService _userInterfaceService;

    private readonly IBettingIntervalService _bettingIntervalService;

    private readonly ILeadPlayerService _leadPlayerService;

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

    public async Task<PhaseResponse> ExecuteAsync(PhaseRequest request)
    {
        var currentBettor = await GetCurrentBettorAsync(request);
        _userInterfaceService.WriteLine($"{currentBettor.Name} starts the bet.");

        Dictionary<Guid, Player> players = request
            .Game
            .Players
            .ToDictionary(p => p.Id, p => p);

        var betResponse = BettingIntervalResponses.Empty with { Pot = request.Pot };

        while (!betResponse.CloseBetting)
        {
            BettingIntervalRequest betRequest = new()
            {
                CurrentBet = betResponse.CurrentBet,
                Pot = betResponse.Pot,
                PlayerInTurn = players[currentBettor.Id],
                ActivePlayers = players.Values.NotFolded().ToList()
            };

            betResponse = await _bettingIntervalService.ExecuteAsync(betRequest);

            _userInterfaceService.WriteLine($"{currentBettor.Name} {betResponse.Description}.");

            players[currentBettor.Id] = betResponse.PlayerInTurn;

            currentBettor =
                betResponse.CloseBetting ? currentBettor
                    : request.Game.Players.NotFolded().ToList().NextPlayer(currentBettor);
        }

        var activePlayers = players.Values.NotFolded().ToList();
        var gameOver = activePlayers.Count == 1;

        PhaseResponse response = new()
        {
            Deck = request.Deck,
            CommunityCards = request.CommunityCards,
            Players = players.Values.ToList(),
            Winners = gameOver ? activePlayers : [],
            GameOver = gameOver,
            Pot = betResponse.Pot
        };

        return response;
    }

    private async Task<Player> GetCurrentBettorAsync(PhaseRequest request)
    {
        var anyFaceUpCards = request.Game.Players
            .SelectMany(p => p.CardsInPlay)
            .FaceUp()
            .Any();

        if (!anyFaceUpCards)
            return GetFirstEligibleBettor(request);

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

    /// <summary>
    /// When there are no face up cards, the player who bets first is the starting player,
    /// or the player closest to him, who has not folded.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException">If all players have folded, this method should not have been invoked.</exception>
    private static Player GetFirstEligibleBettor(PhaseRequest request)
    {
        // if we don't do this check here, we risk an infinite loop
        if (!request.Game.Players.NotFolded().Any())
            throw new InvalidOperationException("All players folded");
        var currentBettor = request.StartingPlayer;
        while (currentBettor.Folded)
            currentBettor = request.Game.Players.NextPlayer(currentBettor);
        return currentBettor;
    }
}
