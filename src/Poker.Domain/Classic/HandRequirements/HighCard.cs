namespace Poker.Domain.Classic.HandRequirements;

public record class HighCard
{
    public static HandRequirement TwoHigh { get; } = new HandRequirement
    {
        Name = "Two High",
        Hand = Hands.HighCard,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static HandRequirement ThreeHigh { get; } = new HandRequirement
    {
        Name = "Three High",
        Hand = Hands.HighCard,
        HighRank = Ranks.Three,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static HandRequirement FourHigh { get; } = new HandRequirement
    {
        Name = "Four High",
        Hand = Hands.HighCard,
        HighRank = Ranks.Four,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 1, Cards = Cards.All.WhereRank(Ranks.Four).ToList() } }
    };

    public static HandRequirement FiveHigh { get; } = new HandRequirement
    {
        Name = "Five High",
        Hand = Hands.HighCard,
        HighRank = Ranks.Five,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 1, Cards = Cards.All.WhereRank(Ranks.Five).ToList() } }
    };

    public static HandRequirement SixHigh { get; } = new HandRequirement
    {
        Name = "Six High",
        Hand = Hands.HighCard,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 1, Cards = Cards.All.WhereRank(Ranks.Six).ToList() } }
    };

    public static HandRequirement SevenHigh { get; } = new HandRequirement
    {
        Name = "Seven High",
        Hand = Hands.HighCard,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 1, Cards = Cards.All.WhereRank(Ranks.Seven).ToList() } }
    };

    public static HandRequirement EightHigh { get; } = new HandRequirement
    {
        Name = "Eight High",
        Hand = Hands.HighCard,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 1, Cards = Cards.All.WhereRank(Ranks.Eight).ToList() } }
    };

    public static HandRequirement NineHigh { get; } = new HandRequirement
    {
        Name = "Nine High",
        Hand = Hands.HighCard,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 1, Cards = Cards.All.WhereRank(Ranks.Nine).ToList() } }
    };

    public static HandRequirement TenHigh { get; } = new HandRequirement
    {
        Name = "Ten High",
        Hand = Hands.HighCard,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 1, Cards = Cards.All.WhereRank(Ranks.Ten).ToList() } }
    };

    public static HandRequirement JackHigh { get; } = new HandRequirement
    {
        Name = "Jack High",
        Hand = Hands.HighCard,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 1, Cards = Cards.All.WhereRank(Ranks.Jack).ToList() } }
    };

    public static HandRequirement QueenHigh { get; } = new HandRequirement
    {
        Name = "Queen High",
        Hand = Hands.HighCard,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 1, Cards = Cards.All.WhereRank(Ranks.Queen).ToList() } }
    };

    public static HandRequirement KingHigh { get; } = new HandRequirement
    {
        Name = "King High",
        Hand = Hands.HighCard,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 1, Cards = Cards.All.WhereRank(Ranks.King).ToList() } }
    };

    public static HandRequirement AceHigh { get; } = new HandRequirement
    {
        Name = "Ace High",
        Hand = Hands.HighCard,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 1, Cards = Cards.All.WhereRank(Ranks.Ace).ToList() } }
    };

    public static List<HandRequirement> All { get; } = new()
    {
        TwoHigh,
        ThreeHigh,
        FourHigh,
        FiveHigh,
        SixHigh,
        SevenHigh,
        EightHigh,
        NineHigh,
        TenHigh,
        JackHigh,
        QueenHigh,
        KingHigh,
        AceHigh
    };
}
