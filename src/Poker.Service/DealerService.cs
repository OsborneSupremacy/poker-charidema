namespace Poker.Service;

internal class DealerService : IDealerService, IPhaseService
{
    private readonly IUserInterfaceService _userInterfaceService;

    private readonly IRandomFactory _randomFactory;

    private readonly ShuffleAlgorithm _shuffleAlgorithm;

    private readonly Dealer _dealer;

    public DealerService(
        IUserInterfaceService userInterfaceService,
        IRandomFactory randomFactory,
        ShuffleAlgorithm shuffleAlgorithm,
        Dealer dealer
        )
    {
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
        _randomFactory = randomFactory ?? throw new ArgumentNullException(nameof(randomFactory));
        _shuffleAlgorithm = shuffleAlgorithm ?? throw new ArgumentNullException(nameof(shuffleAlgorithm));
        _dealer = dealer ?? throw new ArgumentNullException(nameof(dealer));
    }

    public Task<PhaseResponse> ExecuteAsync(PhaseRequest request)
    {
        if(request.GameOver)
            return Task.FromResult(request.ToGameOverResponse());

        _userInterfaceService.WriteHeading(HeadingLevel.Five, $"{request.Phase.Name}");

        var dealResponse = _dealer(new DealRequest
        {
            Deck = request.Deck,
            Players = request.Game.Players,
            CommunityCards = request.CommunityCards,
            StartingPlayer = request.StartingPlayer,
            CardsToDealCount = request.Phase.CardsToDealCount,
            CardOrientation = request.Phase.CardOrientation
        });

        return Task.FromResult(new PhaseResponse
        {
            Deck = dealResponse.Deck,
            CommunityCards = dealResponse.CommunityCards,
            Players = dealResponse.Players,
            Winners = [],
            GameOver = false,
            Pot = request.Pot
        });
    }

    public Task<Deck> ShuffleAsync(Deck deck) =>
        Task.FromResult(
            _shuffleAlgorithm(_randomFactory.Create(), deck)
        );

    public Task<Deck> ReshuffleAsync(ReshuffleRequest request)
    {
        var cards = request.Deck.Cards;
        foreach (var player in request.Players)
            cards.AddRange(player.CardsInPlay.ToCards());

        var deck = request.Deck with
        {
            Cards = cards
        };

        return ShuffleAsync(deck);
    }
}
