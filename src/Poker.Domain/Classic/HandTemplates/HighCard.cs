namespace Poker.Domain.Classic;

public partial record HandTemplates
{
    public static HandTemplate TwoHigh { get; } = new HandTemplate
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

    public static HandTemplate ThreeHigh { get; } = new HandTemplate
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

    public static HandTemplate FourHigh { get; } = new HandTemplate
    {
        Name = "Four High",
        Hand = Hands.HighCard,
        HighRank = Ranks.Four,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 1, Cards = Cards.All.WhereRank(Ranks.Four).ToList() } }
    };

    public static HandTemplate FiveHigh { get; } = new HandTemplate
    {
        Name = "Five High",
        Hand = Hands.HighCard,
        HighRank = Ranks.Five,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 1, Cards = Cards.All.WhereRank(Ranks.Five).ToList() } }
    };

    public static HandTemplate SixHigh { get; } = new HandTemplate
    {
        Name = "Six High",
        Hand = Hands.HighCard,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 1, Cards = Cards.All.WhereRank(Ranks.Six).ToList() } }
    };

    public static HandTemplate SevenHigh { get; } = new HandTemplate
    {
        Name = "Seven High",
        Hand = Hands.HighCard,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 1, Cards = Cards.All.WhereRank(Ranks.Seven).ToList() } }
    };

    public static HandTemplate EightHigh { get; } = new HandTemplate
    {
        Name = "Eight High",
        Hand = Hands.HighCard,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 1, Cards = Cards.All.WhereRank(Ranks.Eight).ToList() } }
    };

    public static HandTemplate NineHigh { get; } = new HandTemplate
    {
        Name = "Nine High",
        Hand = Hands.HighCard,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 1, Cards = Cards.All.WhereRank(Ranks.Nine).ToList() } }
    };

    public static HandTemplate TenHigh { get; } = new HandTemplate
    {
        Name = "Ten High",
        Hand = Hands.HighCard,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 1, Cards = Cards.All.WhereRank(Ranks.Ten).ToList() } }
    };

    public static HandTemplate JackHigh { get; } = new HandTemplate
    {
        Name = "Jack High",
        Hand = Hands.HighCard,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 1, Cards = Cards.All.WhereRank(Ranks.Jack).ToList() } }
    };

    public static HandTemplate QueenHigh { get; } = new HandTemplate
    {
        Name = "Queen High",
        Hand = Hands.HighCard,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 1, Cards = Cards.All.WhereRank(Ranks.Queen).ToList() } }
    };

    public static HandTemplate KingHigh { get; } = new HandTemplate
    {
        Name = "King High",
        Hand = Hands.HighCard,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 1, Cards = Cards.All.WhereRank(Ranks.King).ToList() } }
    };

    public static HandTemplate AceHigh { get; } = new HandTemplate
    {
        Name = "Ace High",
        Hand = Hands.HighCard,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 1, Cards = Cards.All.WhereRank(Ranks.Ace).ToList() } }
    };

    public static List<HandTemplate> AllHighCards { get; } = new()
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
