namespace Poker.Domain.Functions;

public static class DefaultDealer
{
    public static readonly Dealer Deal = request =>
    {
        var playersOut = request.Players;
        
        var ccOut = request.CommunityCards;
        var deckOut = request.Deck;

        var playerInTurn = playersOut
            .Single(p => p == request.StartingPlayer);

        for(var c = 0; c < request.CardsToDealCount; c++)
        {
            for(var i = 0; i < request.Players.Count; i++)
            {
                if(playerInTurn.Folded)
                    continue;

                var dealResponse = DealCard(
                    new() {
                        Deck = deckOut,
                        Player = playerInTurn
                    }
                );
                
                if(!dealResponse.CardWasDealt)
                    continue;
                
                playerInTurn = playersOut.NextPlayer(playerInTurn);
                playersOut.RemoveAll(p => p.Id == dealResponse.Player.Id);
                playersOut.Add(dealResponse.Player);
            }
        }
        return new DealResponse {
            Deck = deckOut,
            CommunityCards = ccOut,
            Players = playersOut
        };
    };
    
    private static DealCardResponse DealCard(DealCardRequest request)
    {
        var cardToDeal = request.Deck.Cards.FirstOrDefault();
        
        if(cardToDeal is null)
            return new DealCardResponse
            {
                Card = Cards.Empty,
                Player = request.Player,
                Deck = request.Deck,
                CardWasDealt = false
            };

        var playerCardsOut = request.Player.Cards;
        playerCardsOut.Add(cardToDeal);

        var deckCardsOut = request.Deck.Cards;
        deckCardsOut.Remove(cardToDeal);

        return new DealCardResponse
        {
            Card = cardToDeal,
            Player = request.Player with { Cards = playerCardsOut },
            Deck = request.Deck with { Cards = deckCardsOut },
            CardWasDealt = true
        };
    }
    
    private record DealCardRequest
    {
        public required Deck Deck { get; init; }

        public required Player Player { get; init; }
    }

    private record DealCardResponse
    {
        public required Card Card { get; init; }

        public required Deck Deck { get; init; }

        public required Player Player { get; init; }
    
        public required bool CardWasDealt { get; init; }
    }
}
