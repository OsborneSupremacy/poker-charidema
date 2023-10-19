namespace Poker.Domain.Messaging.Extensions;

internal static class EvaluatedHandResponseExtensions
{
    public static PlayerHand ToPlayerHand(this EvaluatedHandResponse input)
    {
        var handCards = input.EvaluatedHandSegments
            .Select(s => s.Contributing)
            .Combine();

        var allUnused = input
            .UnusedCards
            .UnusedStandard
            .Concat(
                input.UnusedCards.UnusedWild
            )
            .OrderByDescending(c => c.IsWild)
            .ThenByDescending(c => c.Rank.Value)
            .ThenByDescending(c => c.Suit.Priority)
            .ToList();

        var kickers = allUnused
            .Take(GlobalConstants.HandSize - handCards.Count())
            .ToList();

        return new PlayerHand
        {
            Hand = input.Hand,
            HandCards = handCards,
            Kickers = kickers,
            DeadCards = allUnused.Except(kickers).ToList()
        };
    }
}
