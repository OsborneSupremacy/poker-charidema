namespace Poker.Domain.Classic;

public partial record HandTemplates
{
    public static HandTemplate FiveTwos { get; } = new HandTemplate
    {
        Name = "Five Twos",
        Hand = Hands.ThreeOfAKind,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 5,
                Cards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static HandTemplate FiveThrees { get; } = new HandTemplate
    {
        Name = "Five Threes",
        Hand = Hands.ThreeOfAKind,
        HighRank = Ranks.Three,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 5,
                Cards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static HandTemplate FiveFours { get; } = new HandTemplate
    {
        Name = "Five Fours",
        Hand = Hands.ThreeOfAKind,
        HighRank = Ranks.Four,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 5,
                Cards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static HandTemplate FiveFives { get; } = new HandTemplate
    {
        Name = "Five Fives",
        Hand = Hands.ThreeOfAKind,
        HighRank = Ranks.Five,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 5,
                Cards = Cards.All.WhereRank(Ranks.Five).ToList()
            }
        }
    };

    public static HandTemplate FiveSixes { get; } = new HandTemplate
    {
        Name = "Five Sixes",
        Hand = Hands.ThreeOfAKind,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 5,
                Cards = Cards.All.WhereRank(Ranks.Six).ToList()
            }
        }
    };

    public static HandTemplate FiveSevens { get; } = new HandTemplate
    {
        Name = "Five Sevens",
        Hand = Hands.ThreeOfAKind,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 5,
                Cards = Cards.All.WhereRank(Ranks.Seven).ToList()
            }
        }
    };

    public static HandTemplate FiveEights { get; } = new HandTemplate
    {
        Name = "Five Eights",
        Hand = Hands.ThreeOfAKind,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 5,
                Cards = Cards.All.WhereRank(Ranks.Eight).ToList()
            }
        }
    };

    public static HandTemplate FiveNines { get; } = new HandTemplate
    {
        Name = "Five Nines",
        Hand = Hands.ThreeOfAKind,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 5,
                Cards = Cards.All.WhereRank(Ranks.Nine).ToList()
            }
        }
    };

    public static HandTemplate FiveTens { get; } = new HandTemplate
    {
        Name = "Five Tens",
        Hand = Hands.ThreeOfAKind,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 5,
                Cards = Cards.All.WhereRank(Ranks.Ten).ToList()
            }
        }
    };

    public static HandTemplate FiveJacks { get; } = new HandTemplate
    {
        Name = "Five Jacks",
        Hand = Hands.ThreeOfAKind,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 5,
                Cards = Cards.All.WhereRank(Ranks.Jack).ToList()
            }
        }
    };

    public static HandTemplate FiveQueens { get; } = new HandTemplate
    {
        Name = "Five Queens",
        Hand = Hands.ThreeOfAKind,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 5,
                Cards = Cards.All.WhereRank(Ranks.Queen).ToList()
            }
        }
    };

    public static HandTemplate FiveKings { get; } = new HandTemplate
    {
        Name = "Five Kings",
        Hand = Hands.ThreeOfAKind,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 5,
                Cards = Cards.All.WhereRank(Ranks.King).ToList()
            }
        }
    };

    public static HandTemplate FiveAces { get; } = new HandTemplate
    {
        Name = "Five Aces",
        Hand = Hands.ThreeOfAKind,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 5,
                Cards = Cards.All.WhereRank(Ranks.Ace).ToList()
            }
        }
    };

    public static List<HandTemplate> AllFiveOfAKind { get; } = new()
    {
        FiveTwos,
        FiveThrees,
        FiveFours,
        FiveFives,
        FiveSixes,
        FiveSevens,
        FiveEights,
        FiveNines,
        FiveTens,
        FiveJacks,
        FiveQueens,
        FiveKings,
        FiveAces
    };
}
