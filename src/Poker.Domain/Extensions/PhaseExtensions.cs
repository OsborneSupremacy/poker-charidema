namespace Poker.Domain.Extensions;

public static class PhaseExtensions
{
    /// <summary>
    /// The most cards a participant may draw, given the cards they keep. An override
    /// applies only when a card of its rank is kept (e.g. drawing four when keeping an ace).
    /// </summary>
    public static int GetDrawMaximum(this Phase input, IEnumerable<Card> keptCards)
    {
        var kept = keptCards.ToList();

        return input.CardsToDrawMaximumOverrides
            .Where(o => kept.Any(c => c.MatchesRank(o.Rank)))
            .Select(o => o.Maximum)
            .Append(input.CardsToDrawMaximum)
            .Max();
    }
}
