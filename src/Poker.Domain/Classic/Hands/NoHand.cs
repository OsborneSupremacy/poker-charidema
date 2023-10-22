namespace Poker.Domain.Classic.Hands;

public static class NoHands
{
    public static Hand NoHand { get; } = new Hand
    {
        Name = "No Hand",
        HandDefinition = HandDefinitions.NoHand,
        HighRank = Ranks.Empty,
        Suit = Suits.Empty,
        HandSegments = new()
        {
            new()
            {
                RequiredCount = 0,
                EligibleCards = new()
            }
        }
    };
    
    public static List<Hand> All { get; } = new()
    {
        NoHand
    };
}
