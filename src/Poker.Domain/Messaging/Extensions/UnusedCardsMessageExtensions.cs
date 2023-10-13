namespace Poker.Domain.Messaging.Extensions;

public static class UnusedCardsMessageExtensions
{
    public static bool Any(this UnusedCardsMessage input) =>
        input.UnusedStandard.Any() || input.UnusedWild.Any();
}
