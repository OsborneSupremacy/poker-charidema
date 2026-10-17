namespace Poker.Domain.Functions;

public static class DefaultDrawer
{
    /// <summary>
    /// Moves the cards to discard from the participant's hand to the discard pile,
    /// and replaces them with the same number of cards from the top of the deck.
    /// Does not enforce the phase's draw maximum; that is the caller's responsibility.
    /// </summary>
    public static readonly Drawer Draw = request =>
    {
        var handOut = request.Participant.CardsInPlay.ToList();

        foreach (var card in request.CardsToDiscard)
        {
            var index = handOut.FindIndex(c => c.Card == card);

            if (index < 0)
                throw new InvalidOperationException(
                    $"{request.Participant.Name} cannot discard the {card.Rank.Name} of {card.Suit.Name}, since it is not in their hand.");

            handOut.RemoveAt(index);
        }

        if (request.Deck.Cards.Count < request.CardsToDiscard.Count)
            throw new InvalidOperationException(
                $"The deck has {request.Deck.Cards.Count} cards, which is not enough to draw {request.CardsToDiscard.Count}.");

        var cardsDrawn = request.Deck.Cards
            .Take(request.CardsToDiscard.Count)
            .ToList();

        handOut.AddRange(cardsDrawn.DealToPlayer(request.CardOrientation));

        return new DrawResponse
        {
            Participant = request.Participant with { CardsInPlay = handOut },
            Deck = request.Deck with { Cards = request.Deck.Cards.Skip(cardsDrawn.Count).ToList() },
            Discards = request.Discards
                .Concat(request.CardsToDiscard.ToDiscards())
                .ToList(),
            CardsDrawn = cardsDrawn
        };
    };
}
