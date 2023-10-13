namespace Poker.Domain.Classic;

public partial record Hands
{
    public static Hand ThreeTwos { get; } = new Hand
    {
        Name = "Three Twos",
        HandDefinition = HandDefinitions.ThreeOfAKind,
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

    public static Hand ThreeThrees { get; } = new Hand
    {
        Name = "Three Threes",
        HandDefinition = HandDefinitions.ThreeOfAKind,
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

    public static Hand ThreeFours { get; } = new Hand
    {
        Name = "Three Fours",
        HandDefinition = HandDefinitions.ThreeOfAKind,
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

    public static Hand ThreeFives { get; } = new Hand
    {
        Name = "Three Fives",
        HandDefinition = HandDefinitions.ThreeOfAKind,
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

    public static Hand ThreeSixes { get; } = new Hand
    {
        Name = "Three Sixes",
        HandDefinition = HandDefinitions.ThreeOfAKind,
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

    public static Hand ThreeSevens { get; } = new Hand
    {
        Name = "Three Sevens",
        HandDefinition = HandDefinitions.ThreeOfAKind,
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

    public static Hand ThreeEights { get; } = new Hand
    {
        Name = "Three Eights",
        HandDefinition = HandDefinitions.ThreeOfAKind,
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

    public static Hand ThreeNines { get; } = new Hand
    {
        Name = "Three Nines",
        HandDefinition = HandDefinitions.ThreeOfAKind,
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

    public static Hand ThreeTens { get; } = new Hand
    {
        Name = "Three Tens",
        HandDefinition = HandDefinitions.ThreeOfAKind,
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

    public static Hand ThreeJacks { get; } = new Hand
    {
        Name = "Three Jacks",
        HandDefinition = HandDefinitions.ThreeOfAKind,
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

    public static Hand ThreeQueens { get; } = new Hand
    {
        Name = "Three Queens",
        HandDefinition = HandDefinitions.ThreeOfAKind,
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

    public static Hand ThreeKings { get; } = new Hand
    {
        Name = "Three Kings",
        HandDefinition = HandDefinitions.ThreeOfAKind,
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

    public static Hand ThreeAces { get; } = new Hand
    {
        Name = "Three Aces",
        HandDefinition = HandDefinitions.ThreeOfAKind,
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

    public static List<Hand> AllThreeOfAKind { get; } = new()
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
