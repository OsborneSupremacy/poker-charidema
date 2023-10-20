namespace Poker.Domain.Classic.Hands;

public static class Flushes
{
    public static Hand Spades { get; } = new Hand
    {
        Name = "Spades Flush",
        HandDefinition = HandDefinitions.Flush,
        HighRank = Ranks.Empty,
        Suit = Suits.Spades,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = Cards.All.WhereSuit(Suits.Spades).ToList()
            }
        }
    };

    public static Hand Hearts { get; } = new Hand
    {
        Name = "Hearts Flush",
        HandDefinition = HandDefinitions.Flush,
        HighRank = Ranks.Empty,
        Suit = Suits.Hearts,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = Cards.All.WhereSuit(Suits.Hearts).ToList()
            }
        }
    };

    public static Hand Diamonds { get; } = new Hand
    {
        Name = "Diamonds Flush",
        HandDefinition = HandDefinitions.Flush,
        HighRank = Ranks.Empty,
        Suit = Suits.Diamonds,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = Cards.All.WhereSuit(Suits.Diamonds).ToList()
            }
        }
    };

    public static Hand Clubs { get; } = new Hand
    {
        Name = "Clubs Flush",
        HandDefinition = HandDefinitions.Flush,
        HighRank = Ranks.Empty,
        Suit = Suits.Clubs,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = Cards.All.WhereSuit(Suits.Clubs).ToList()
            }
        }
    };

    public static List<Hand> All { get; } = new()
    {
        Spades,
        Hearts,
        Clubs,
        Diamonds
    };
}
