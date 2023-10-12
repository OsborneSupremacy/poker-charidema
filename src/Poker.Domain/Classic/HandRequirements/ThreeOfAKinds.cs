namespace Poker.Domain.Classic.HandRequirements;

public record class ThreeOfAKinds
{
    public static HandRequirement Twos { get; } = new HandRequirement
    {
        Name = "Three Twos",
        Hand = Hands.ThreeOfAKind,
        HighRank =Ranks.Two,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static HandRequirement Threes { get; } = new HandRequirement
    {
        Name = "Three Threes",
        Hand = Hands.ThreeOfAKind,
        HighRank =Ranks.Three,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static HandRequirement Fours { get; } = new HandRequirement
    {
        Name = "Three Fours",
        Hand = Hands.ThreeOfAKind,
        HighRank =Ranks.Four,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static HandRequirement Fives { get; } = new HandRequirement
    {
        Name = "Three Fives",
        Hand = Hands.ThreeOfAKind,
        HighRank =Ranks.Five,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Five).ToList()
            }
        }
    };

    public static HandRequirement Sixes { get; } = new HandRequirement
    {
        Name = "Three Sixes",
        Hand = Hands.ThreeOfAKind,
        HighRank =Ranks.Six,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Six).ToList()
            }
        }
    };

    public static HandRequirement Sevens { get; } = new HandRequirement
    {
        Name = "Three Sevens",
        Hand = Hands.ThreeOfAKind,
        HighRank =Ranks.Seven,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Seven).ToList()
            }
        }
    };

    public static HandRequirement Eights { get; } = new HandRequirement
    {
        Name = "Three Eights",
        Hand = Hands.ThreeOfAKind,
        HighRank =Ranks.Eight,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Eight).ToList()
            }
        }
    };

    public static HandRequirement Nines { get; } = new HandRequirement
    {
        Name = "Three Nines",
        Hand = Hands.ThreeOfAKind,
        HighRank =Ranks.Nine,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Nine).ToList()
            }
        }
    };

    public static HandRequirement Tens { get; } = new HandRequirement
    {
        Name = "Three Tens",
        Hand = Hands.ThreeOfAKind,
        HighRank =Ranks.Ten,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Ten).ToList()
            }
        }
    };

    public static HandRequirement Jacks { get; } = new HandRequirement
    {
        Name = "Three Jacks",
        Hand = Hands.ThreeOfAKind,
        HighRank =Ranks.Jack,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Jack).ToList()
            }
        }
    };

    public static HandRequirement Queens { get; } = new HandRequirement
    {
        Name = "Three Queens",
        Hand = Hands.ThreeOfAKind,
        HighRank =Ranks.Queen,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Queen).ToList()
            }
        }
    };

    public static HandRequirement Kings { get; } = new HandRequirement
    {
        Name = "Three Kings",
        Hand = Hands.ThreeOfAKind,
        HighRank =Ranks.King,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.King).ToList()
            }
        }
    };

    public static HandRequirement Aces { get; } = new HandRequirement
    {
        Name = "Three Aces",
        Hand = Hands.ThreeOfAKind,
        HighRank =Ranks.Ace,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Ace).ToList()
            }
        }
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
