namespace Poker.Domain.Extensions;

public static class VariantExtensions
{
    public static int GetRemainingCardCount(this Variant input, int lastPhaseNumber) =>
        input.Phases
            .Where(x => x.Number > lastPhaseNumber)
            .Where(x => x.PhaseType == PhaseType.Deal)
            .Sum(x => x.CardsToDealCount);
}
