namespace Poker.Domain.Classic;

public partial record HandTemplates
{
    public static HandTemplate FourTwos { get; } = new HandTemplate
    {
        Name = "Four Twos",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 4,
                Cards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static HandTemplate FourThrees { get; } = new HandTemplate
    {
        Name = "Four Threes",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Three,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 4,
                Cards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static HandTemplate FourFours { get; } = new HandTemplate
    {
        Name = "Four Fours",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Four,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 4,
                Cards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static HandTemplate FourFives { get; } = new HandTemplate
    {
        Name = "Four Fives",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Five,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 4,
                Cards = Cards.All.WhereRank(Ranks.Five).ToList()
            }
        }
    };

    public static HandTemplate FourSixes { get; } = new HandTemplate
    {
        Name = "Four Sixes",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 4,
                Cards = Cards.All.WhereRank(Ranks.Six).ToList()
            }
        }
    };

    public static HandTemplate FourSevens { get; } = new HandTemplate
    {
        Name = "Four Sevens",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 4,
                Cards = Cards.All.WhereRank(Ranks.Seven).ToList()
            }
        }
    };

    public static HandTemplate FourEights { get; } = new HandTemplate
    {
        Name = "Four Eights",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 4,
                Cards = Cards.All.WhereRank(Ranks.Eight).ToList()
            }
        }
    };

    public static HandTemplate FourNines { get; } = new HandTemplate
    {
        Name = "Four Nines",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 4,
                Cards = Cards.All.WhereRank(Ranks.Nine).ToList()
            }
        }
    };

    public static HandTemplate FourTens { get; } = new HandTemplate
    {
        Name = "Four Tens",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 4,
                Cards = Cards.All.WhereRank(Ranks.Ten).ToList()
            }
        }
    };

    public static HandTemplate FourJacks { get; } = new HandTemplate
    {
        Name = "Four Jacks",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 4,
                Cards = Cards.All.WhereRank(Ranks.Jack).ToList()
            }
        }
    };

    public static HandTemplate FourQueens { get; } = new HandTemplate
    {
        Name = "Four Queens",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 4,
                Cards = Cards.All.WhereRank(Ranks.Queen).ToList()
            }
        }
    };

    public static HandTemplate FourKings { get; } = new HandTemplate
    {
        Name = "Four Kings",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 4,
                Cards = Cards.All.WhereRank(Ranks.King).ToList()
            }
        }
    };

    public static HandTemplate FourAces { get; } = new HandTemplate
    {
        Name = "Four Aces",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 4,
                Cards = Cards.All.WhereRank(Ranks.Ace).ToList()
            }
        }
    };

    public static List<HandTemplate> AllFourOfAKind { get; } = new()
    {
        FourTwos,
        FourThrees,
        FourFours,
        FourFives,
        FourSixes,
        FourSevens,
        FourEights,
        FourNines,
        FourTens,
        FourJacks,
        FourQueens,
        FourKings,
        FourAces
    };
}
