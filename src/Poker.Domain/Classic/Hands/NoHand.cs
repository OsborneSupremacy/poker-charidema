namespace Poker.Domain.Classic;

public partial record Hands
{
    public static Hand NoHand { get; } = new Hand
    {
        Name = "No Hand",
        HandDefinition = HandDefinitions.NoHand,
        HighRank = Ranks.Empty,
        Suit = Suits.Empty,
        HandSegments = new()
    };
}
