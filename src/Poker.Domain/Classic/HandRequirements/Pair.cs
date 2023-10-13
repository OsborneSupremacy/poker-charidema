namespace Poker.Domain.Classic.HandRequirements;

public record Pair
{
    public static HandRequirement Twos { get; } = new HandRequirement
    {
        Name = "Pair of Twos",
        Hand = Hands.Pair,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static HandRequirement Threes { get; } = new HandRequirement
    {
        Name = "Pair of Threes",
        Hand = Hands.Pair,
        HighRank = Ranks.Three,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static HandRequirement Fours { get; } = new HandRequirement
    {
        Name = "Pair of Fours",
        Hand = Hands.Pair,
        HighRank = Ranks.Four,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static HandRequirement Fives { get; } = new HandRequirement
    {
        Name = "Pair of Fives",
        Hand = Hands.Pair,
        HighRank = Ranks.Five,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 2, Cards = Cards.All.WhereRank(Ranks.Five).ToList() } }
    };

    public static HandRequirement Sixes { get; } = new HandRequirement
    {
        Name = "Pair of Sixes",
        Hand = Hands.Pair,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 2, Cards = Cards.All.WhereRank(Ranks.Six).ToList() } }
    };

    public static HandRequirement Sevens { get; } = new HandRequirement
    {
        Name = "Pair of Sevens",
        Hand = Hands.Pair,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 2, Cards = Cards.All.WhereRank(Ranks.Seven).ToList() } }
    };

    public static HandRequirement Eights { get; } = new HandRequirement
    {
        Name = "Pair of Eights",
        Hand = Hands.Pair,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 2, Cards = Cards.All.WhereRank(Ranks.Eight).ToList() } }
    };

    public static HandRequirement Nines { get; } = new HandRequirement
    {
        Name = "Pair of Nines",
        Hand = Hands.Pair,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 2, Cards = Cards.All.WhereRank(Ranks.Nine).ToList() } }
    };

    public static HandRequirement Tens { get; } = new HandRequirement
    {
        Name = "Pair of Tens",
        Hand = Hands.Pair,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 2, Cards = Cards.All.WhereRank(Ranks.Ten).ToList() } }
    };

    public static HandRequirement Jacks { get; } = new HandRequirement
    {
        Name = "Pair of Jacks",
        Hand = Hands.Pair,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 2, Cards = Cards.All.WhereRank(Ranks.Jack).ToList() } }
    };

    public static HandRequirement Queens { get; } = new HandRequirement
    {
        Name = "Pair of Queens",
        Hand = Hands.Pair,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 2, Cards = Cards.All.WhereRank(Ranks.Queen).ToList() } }
    };

    public static HandRequirement Kings { get; } = new HandRequirement
    {
        Name = "Pair of Kings",
        Hand = Hands.Pair,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 2, Cards = Cards.All.WhereRank(Ranks.King).ToList() } }
    };

    public static HandRequirement Aces { get; } = new HandRequirement
    {
        Name = "Pair of Aces",
        Hand = Hands.Pair,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 2, Cards = Cards.All.WhereRank(Ranks.Ace).ToList() } }
    };

    public static List<HandRequirement> All { get; } = new()
    {
        Twos,
        Threes,
        Fours,
        Fives,
        Sixes,
        Sevens,
        Eights,
        Nines,
        Tens,
        Jacks,
        Queens,
        Kings,
        Aces
    };
}
