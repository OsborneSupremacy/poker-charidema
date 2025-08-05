namespace Poker.Domain.Functions;

public static class DefaultDealer
{
    public static readonly Dealer Deal = request =>
    {
        var playersOut = request.Participants.ToList();

        var ccOut = request.CommunityCards;
        var deckOut = request.Deck;

        var playerInTurn = playersOut
            .Single(p => p == request.StartingParticipant);

        for (var c = 0; c < request.CardsToDealCount; c++)
        {
            for (var i = 0; i < request.Participants.Count; i++)
            {
                if (playerInTurn.Folded)
                    continue;

                var dealResponse = DealCard(
                    new()
                    {
                        Deck = deckOut,
                        Participant = playerInTurn,
                        CardOrientation = request.CardOrientation
                    }
                );

                if (!dealResponse.CardWasDealt)
                    continue;

                deckOut = dealResponse.Deck;

                playerInTurn = playersOut.NextParticipant(playerInTurn);
                playersOut.RemoveAll(p => p.Id == dealResponse.Participant.Id);
                playersOut.Add(dealResponse.Participant);
            }
        }
        return new DealResponse
        {
            Deck = deckOut,
            CommunityCards = ccOut,
            Participants = playersOut
        };
    };

    private static DealCardResponse DealCard(DealCardRequest request)
    {
        var cardToDeal = request.Deck.Cards.FirstOrDefault() ?? Cards.Empty;

        if (cardToDeal == Cards.Empty)
            return new DealCardResponse
            {
                Card = Cards.Empty,
                Participant = request.Participant,
                Deck = request.Deck,
                CardWasDealt = false
            };

        var playerCardsOut = request.Participant.CardsInPlay.ToList();
        playerCardsOut.Add(cardToDeal.DealToPlayer(request.CardOrientation));

        var deckCardsOut = request.Deck.Cards.ToList();
        deckCardsOut.Remove(cardToDeal);

        return new DealCardResponse
        {
            Card = cardToDeal,
            Participant = request.Participant with { CardsInPlay = playerCardsOut },
            Deck = request.Deck with { Cards = deckCardsOut },
            CardWasDealt = true
        };
    }

    private record DealCardRequest
    {
        public required Deck Deck { get; init; }

        public required Participant Participant { get; init; }

        public required CardOrientation CardOrientation { get; init; }
    }

    private record DealCardResponse
    {
        public required Card Card { get; init; }

        public required Deck Deck { get; init; }

        public required Participant Participant { get; init; }

        public required bool CardWasDealt { get; init; }
    }
}
