namespace Poker.Domain.Extensions;

public static class VariantExtensions
{
    /// <summary>
    /// The most cards a participant could still receive after the given phase,
    /// from both deals and draws. Draws count at their highest possible maximum,
    /// since a hand is possible if any sequence of draws could complete it.
    /// </summary>
    public static int GetRemainingCardCount(this Variant input, int lastPhaseNumber) =>
        input.Phases
            .Where(x => x.Number > lastPhaseNumber)
            .Sum(x => x.PhaseType switch
            {
                PhaseType.Deal => x.CardsToDealCount,
                PhaseType.Draw => x.CardsToDrawMaximumOverrides
                    .Select(o => o.Maximum)
                    .Append(x.CardsToDrawMaximum)
                    .Max(),
                _ => 0
            });
}
