namespace Poker.Domain.Functions;

public static class DefaultDealer
{
    public static readonly Dealer Deal = request =>
        request.CardDestination switch
        {
            CardLocation.Community => DealToCommunity(request),
            _ => DealToParticipants(request)
        };

    private static DealResponse DealToCommunity(DealRequest request)
    {
        var cardsToDeal = request.Deck.Cards
            .Take(request.CardsToDealCount)
            .ToList();

        foreach (var card in cardsToDeal)
            request.CardDealtToCommunityAction(new() { Card = card });

        return new DealResponse
        {
            Deck = request.Deck with { Cards = request.Deck.Cards.Skip(cardsToDeal.Count).ToList() },
            CommunityCards = request.CommunityCards
                .Concat(cardsToDeal.DealToCommunity(request.CardOrientation))
                .ToList(),
            Participants = request.Participants
        };
    }

    private static DealResponse DealToParticipants(DealRequest request)
    {
        var playersOut = request.Participants.ToList();

        var ccOut = request.CommunityCards;
        var deckOut = request.Deck;

        var dealingOrder = GetDealingOrder(request);

        for (var c = 0; c < request.CardsToDealCount; c++)
        {
            foreach (var participantId in dealingOrder)
            {
                var index = playersOut.FindIndex(p => p.Id == participantId);

                var dealResponse = DealCard(
                    new()
                    {
                        Deck = deckOut,
                        Participant = playersOut[index],
                        CardOrientation = request.CardOrientation
                    }
                );

                if (!dealResponse.CardWasDealt)
                    continue;

                request.CardDealtToParticipantAction(new()
                {
                    Card = dealResponse.Card,
                    Participant = dealResponse.Participant
                });

                deckOut = dealResponse.Deck;
                playersOut[index] = dealResponse.Participant;
            }
        }
        return new DealResponse
        {
            Deck = deckOut,
            CommunityCards = ccOut,
            Participants = playersOut
        };
    }

    /// <summary>
    /// The ids of the participants who have not folded, in seat order,
    /// beginning with the starting participant.
    /// </summary>
    private static List<Guid> GetDealingOrder(DealRequest request)
    {
        var startingIndex = request.Participants
            .ToList()
            .FindIndex(p => p.Id == request.StartingParticipant.Id);

        return request.Participants
            .Skip(startingIndex)
            .Concat(request.Participants.Take(startingIndex))
            .NotFolded()
            .Select(p => p.Id)
            .ToList();
    }

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
