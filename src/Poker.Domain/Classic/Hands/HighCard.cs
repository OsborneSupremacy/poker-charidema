namespace Poker.Domain.Classic.Hands;

public static class HighCards
{
    public static Hand Two { get; } = new Hand
    {
        Name = "Two High",
        HandDefinition = HandDefinitions.HighCard,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static Hand Three { get; } = new Hand
    {
        Name = "Three High",
        HandDefinition = HandDefinitions.HighCard,
        HighRank = Ranks.Three,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static Hand Four { get; } = new Hand
    {
        Name = "Four High",
        HandDefinition = HandDefinitions.HighCard,
        HighRank = Ranks.Four,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment> { new() { RequiredCount = 1, EligibleCards = Cards.All.WhereRank(Ranks.Four).ToList() } }
    };

    public static Hand Five { get; } = new Hand
    {
        Name = "Five High",
        HandDefinition = HandDefinitions.HighCard,
        HighRank = Ranks.Five,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment> { new() { RequiredCount = 1, EligibleCards = Cards.All.WhereRank(Ranks.Five).ToList() } }
    };

    public static Hand Six { get; } = new Hand
    {
        Name = "Six High",
        HandDefinition = HandDefinitions.HighCard,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment> { new() { RequiredCount = 1, EligibleCards = Cards.All.WhereRank(Ranks.Six).ToList() } }
    };

    public static Hand Seven { get; } = new Hand
    {
        Name = "Seven High",
        HandDefinition = HandDefinitions.HighCard,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment> { new() { RequiredCount = 1, EligibleCards = Cards.All.WhereRank(Ranks.Seven).ToList() } }
    };

    public static Hand Eight { get; } = new Hand
    {
        Name = "Eight High",
        HandDefinition = HandDefinitions.HighCard,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment> { new() { RequiredCount = 1, EligibleCards = Cards.All.WhereRank(Ranks.Eight).ToList() } }
    };

    public static Hand Nine { get; } = new Hand
    {
        Name = "Nine High",
        HandDefinition = HandDefinitions.HighCard,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment> { new() { RequiredCount = 1, EligibleCards = Cards.All.WhereRank(Ranks.Nine).ToList() } }
    };

    public static Hand Ten { get; } = new Hand
    {
        Name = "Ten High",
        HandDefinition = HandDefinitions.HighCard,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment> { new() { RequiredCount = 1, EligibleCards = Cards.All.WhereRank(Ranks.Ten).ToList() } }
    };

    public static Hand Jack { get; } = new Hand
    {
        Name = "Jack High",
        HandDefinition = HandDefinitions.HighCard,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment> { new() { RequiredCount = 1, EligibleCards = Cards.All.WhereRank(Ranks.Jack).ToList() } }
    };

    public static Hand Queen { get; } = new Hand
    {
        Name = "Queen High",
        HandDefinition = HandDefinitions.HighCard,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment> { new() { RequiredCount = 1, EligibleCards = Cards.All.WhereRank(Ranks.Queen).ToList() } }
    };

    public static Hand King { get; } = new Hand
    {
        Name = "King High",
        HandDefinition = HandDefinitions.HighCard,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment> { new() { RequiredCount = 1, EligibleCards = Cards.All.WhereRank(Ranks.King).ToList() } }
    };

    public static Hand Ace { get; } = new Hand
    {
        Name = "Ace High",
        HandDefinition = HandDefinitions.HighCard,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment> { new() { RequiredCount = 1, EligibleCards = Cards.All.WhereRank(Ranks.Ace).ToList() } }
    };

    public static List<Hand> AllHighCards { get; } = new()
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    };
}
