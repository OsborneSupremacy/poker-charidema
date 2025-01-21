namespace Poker.Service;

/// <inheritdoc />
internal class WinnerEvaluationService : IPhaseService
{
    private readonly IUserInterfaceService _userInterfaceService;

    private readonly WinnerEvaluator _winnerEvaluator;

    private readonly WinningsDistributor _winningsDistributor;

    private readonly HandCollectionEvaluator _handCollectionEvaluator;

    private readonly HandEvaluator _handEvaluator;

    public WinnerEvaluationService(
        IUserInterfaceService userInterfaceService,
        WinnerEvaluator winnerEvaluator,
        WinningsDistributor winningsDistributor,
        HandCollectionEvaluator handCollectionEvaluator,
        HandEvaluator handEvaluator
        )
    {
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
        _winnerEvaluator = winnerEvaluator ?? throw new ArgumentNullException(nameof(winnerEvaluator));
        _winningsDistributor = winningsDistributor ?? throw new ArgumentNullException(nameof(winningsDistributor));
        _handCollectionEvaluator =
            handCollectionEvaluator ?? throw new ArgumentNullException(nameof(handCollectionEvaluator));
        _handEvaluator = handEvaluator ?? throw new ArgumentNullException(nameof(handEvaluator));
    }

    public Task<PhaseResponse> ExecuteAsync(PhaseRequest request)
    {
        _userInterfaceService.WriteHeading(
            HeadingLevel.Five,
            $"{request.Phase.Name}"
        );

        return request.Game.Players.NotFolded().Count() switch
        {
            1 => ExecuteWinByDefaultAsync(request),
            _ => ExecuteContestedAsync(request)
        };
    }

    private Task<PhaseResponse> ExecuteWinByDefaultAsync(PhaseRequest request)
    {
        var winner = request.Game.Players.NotFolded().Single();

        _userInterfaceService.WriteLine($"{winner.Name} wins by default.");

        var playersOut = _winningsDistributor(
            new()
            {
                Players = request.Game.Players,
                Winners = [ winner ],
                Pot = request.Pot
            }
        ).Players;

        return Task.FromResult(new PhaseResponse
        {
            Deck = request.Deck,
            CommunityCards = request.CommunityCards,
            Players = playersOut,
            Winners = [ winner ],
            GameOver = true,
            Pot = request.Pot
        });
    }

    private Task<PhaseResponse> ExecuteContestedAsync(PhaseRequest request)
    {
        var response = _winnerEvaluator(
            new()
            {
                Players = request.Game.Players.NotFolded().ToList(),
                HandCollectionEvaluator = _handCollectionEvaluator,
                HandEvaluator = _handEvaluator
            }
        );

        foreach (var playerHand in response.PlayerHands)
            _userInterfaceService
                .RenderCards
                (
                    playerHand.Player.Name,
                    playerHand
                );

        var label = response.Winners.Count > 1 ? "Winners" : "Winner";

        var messages = response.Winners.Select(w => w.Name).ToList();
        messages.Add($"{response.WinningHand.Name}");

        _userInterfaceService.WriteList(label, messages);

        var playersOut = _winningsDistributor(
            new()
            {
                Players = request.Game.Players,
                Winners = response.Winners,
                Pot = request.Pot
            }
        ).Players;

        return Task.FromResult(new PhaseResponse
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
