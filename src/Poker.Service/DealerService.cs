namespace Poker.Service;

public class DealerService : IDealerService, IPhaseService
{
    private readonly IRandomFactory _randomFactory;

    public DealerService(IRandomFactory randomFactory)
    {
        _randomFactory = randomFactory ?? throw new ArgumentNullException(nameof(randomFactory));
    }

    public Task<PhaseResponse> ExecuteAsync(PhaseRequest request)
    {
        var playersOut = request.Game.Players;
        
        var ccOut = request.CommunityCards;
        var deckOut = request.Deck;

        var playerInTurn = playersOut
            .Single(p => p == request.StartingPlayer);

        for(var c = 0; c < request.Phase.CardsToDealCount; c++)
        {
            for(var i = 0; i < request.Game.Players.Count; i++)
            {
                if(playerInTurn.Folded)
                    continue;

                var dealResponse = DealCard(
                    new() {
                        Deck = deckOut,
                        Phase = request.Phase,
                        Player = playerInTurn
                    }
                );

                deckOut = dealResponse.Deck;
                
                playerInTurn = playersOut.NextPlayer(playerInTurn);
                playersOut.RemoveAll(p => p.Id == dealResponse.Player.Id);
                playersOut.Add(dealResponse.Player);
            }
        }

        return Task.FromResult(new PhaseResponse
        {
            Deck = deckOut,
            CommunityCards = ccOut,
            Players = playersOut,
            Winners = new(),
            GameOver = false,
            Pot = request.Pot
        });
    }

    private DealCardResponse DealCard(DealCardRequest request)
    {
        var cardToDeal = request.Deck.Cards.FirstOrDefault();
        
        if(cardToDeal is null)
            throw new InvalidOperationException("No cards left in deck.");

        var playerCardsOut = request.Player.Cards;
        playerCardsOut.Add(cardToDeal);

        var deckCardsOut = request.Deck.Cards;
        deckCardsOut.Remove(cardToDeal);

        return new DealCardResponse
        {
            Card = cardToDeal,
            Player = request.Player with { Cards = playerCardsOut },
            Deck = request.Deck with { Cards = deckCardsOut }
        };
    }

    public Task<Deck> ShuffleAsync(Deck deck)
    {
        var random = _randomFactory.Create();

        // Fisher-Yates shuffle algorithm
        for (int i = deck.Cards.Count - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            (deck.Cards[j], deck.Cards[i]) = (deck.Cards[i], deck.Cards[j]);
        }

        return Task.FromResult(deck);
    }

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
