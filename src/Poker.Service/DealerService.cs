namespace Poker.Service;

public class DealerService : IDealerService, IPhaseService
{
    private readonly IRandomFactory _randomFactory;

    private readonly ShuffleAlgorithm _shuffleAlgorithm;
    
    private readonly Dealer _dealer;

    public DealerService(
        IRandomFactory randomFactory,
        ShuffleAlgorithm shuffleAlgorithm,
        Dealer dealer
        )
    {
        _randomFactory = randomFactory ?? throw new ArgumentNullException(nameof(randomFactory));
        _shuffleAlgorithm = shuffleAlgorithm ?? throw new ArgumentNullException(nameof(shuffleAlgorithm));
        _dealer = dealer ?? throw new ArgumentNullException(nameof(dealer));
    }

    public Task<PhaseResponse> ExecuteAsync(PhaseRequest request)
    {
        var dealResponse = _dealer(new DealRequest
        {
            Deck = request.Deck,
            Players = request.Game.Players,
            CommunityCards = request.CommunityCards,
            StartingPlayer = request.StartingPlayer,
            CardsToDealCount = request.Phase.CardsToDealCount    
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
        foreach(var player in request.Players)
            cards.AddRange(player.Cards);
        
        var deck = request.Deck with
        {
            Cards = cards
        };

        return ShuffleAsync(deck);
    }
}
