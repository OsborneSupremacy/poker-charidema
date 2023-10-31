namespace Poker.Domain.Extensions;

public static class HandExtensions
{
    public static int GetTotalRequiredCards(this Hand input) =>
        input.HandSegments.Sum(x => x.RequiredCount);
    
    public static bool IsFiveCardHand(this Hand input) =>
        input.GetTotalRequiredCards() == GlobalConstants.HandSize;
}
