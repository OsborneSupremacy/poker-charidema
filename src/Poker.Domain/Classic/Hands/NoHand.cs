namespace Poker.Domain.Classic.Hands;

public record NoHands
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
