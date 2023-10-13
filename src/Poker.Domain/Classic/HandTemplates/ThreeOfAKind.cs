namespace Poker.Domain.Classic;

public partial record HandTemplates
{
    public static HandTemplate ThreeTwos { get; } = new HandTemplate
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

    public static HandTemplate ThreeThrees { get; } = new HandTemplate
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

    public static HandTemplate ThreeFours { get; } = new HandTemplate
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

    public static HandTemplate ThreeFives { get; } = new HandTemplate
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

    public static HandTemplate ThreeSixes { get; } = new HandTemplate
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

    public static HandTemplate ThreeSevens { get; } = new HandTemplate
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

    public static HandTemplate ThreeEights { get; } = new HandTemplate
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

    public static HandTemplate ThreeNines { get; } = new HandTemplate
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

    public static HandTemplate ThreeTens { get; } = new HandTemplate
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

    public static HandTemplate ThreeJacks { get; } = new HandTemplate
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

    public static HandTemplate ThreeQueens { get; } = new HandTemplate
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

    public static HandTemplate ThreeKings { get; } = new HandTemplate
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

    public static HandTemplate ThreeAces { get; } = new HandTemplate
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

    public static List<HandTemplate> AllThreeOfAKind { get; } = new()
    {
        ThreeTwos,
        ThreeThrees,
        ThreeFours,
        ThreeFives,
        ThreeSixes,
        ThreeSevens,
        ThreeEights,
        ThreeNines,
        ThreeTens,
        ThreeJacks,
        ThreeQueens,
        ThreeKings,
        ThreeAces
    };
}
