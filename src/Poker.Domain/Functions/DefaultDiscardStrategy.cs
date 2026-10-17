namespace Poker.Domain.Functions;

public static class DefaultDiscardStrategy
{
    /// <summary>
    /// Keeps the cards that make up the best hand, and discards as many of the
    /// rest as the phase allows, lowest first. Wild cards are discarded last.
    /// Doesn't consider drawing to straights or flushes.
    /// </summary>
    public static readonly DiscardStrategy Select = request =>
    {
        var allCards = request.ParticipantHand.Participant.CardsInPlay.ToCards();

        var candidates = request.ParticipantHand.Kickers
            .Concat(request.ParticipantHand.DeadCards)
            .OrderBy(c => c.IsWild)
            .ThenBy(c => c.Rank.Value)
            .ThenBy(c => c.Suit.Priority)
            .ToList();

        for (var count = candidates.Count; count > 0; count--)
        {
            var discards = candidates.Take(count).ToList();
            var kept = allCards.Except(discards);

            if (count <= request.Phase.GetDrawMaximum(kept))
                return discards;
        }

        return [];
    };
}
