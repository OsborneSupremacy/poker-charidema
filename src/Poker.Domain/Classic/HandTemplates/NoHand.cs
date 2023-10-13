namespace Poker.Domain.Classic;

public partial record HandTemplates
{
    public static HandTemplate NoHand { get; } = new HandTemplate
    {
        Name = "No Hand",
        HandDefinition = HandDefinitions.NoHand,
        HighRank = Ranks.Empty,
        Suit = Suits.Empty,
        CardGroups = new()
    };
}
