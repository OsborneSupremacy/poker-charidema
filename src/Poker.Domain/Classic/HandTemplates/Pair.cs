namespace Poker.Domain.Classic;

public partial record HandTemplates
{
    public static HandTemplate PairOfTwos { get; } = new HandTemplate
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

    public static HandTemplate PairOfThrees { get; } = new HandTemplate
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

    public static HandTemplate PairOfFours { get; } = new HandTemplate
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

    public static HandTemplate PairOfFives { get; } = new HandTemplate
    {
        Name = "Pair of Fives",
        Hand = Hands.Pair,
        HighRank = Ranks.Five,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 2, Cards = Cards.All.WhereRank(Ranks.Five).ToList() } }
    };

    public static HandTemplate PairOfSixes { get; } = new HandTemplate
    {
        Name = "Pair of Sixes",
        Hand = Hands.Pair,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 2, Cards = Cards.All.WhereRank(Ranks.Six).ToList() } }
    };

    public static HandTemplate PairOfSevens { get; } = new HandTemplate
    {
        Name = "Pair of Sevens",
        Hand = Hands.Pair,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 2, Cards = Cards.All.WhereRank(Ranks.Seven).ToList() } }
    };

    public static HandTemplate PairOfEights { get; } = new HandTemplate
    {
        Name = "Pair of Eights",
        Hand = Hands.Pair,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 2, Cards = Cards.All.WhereRank(Ranks.Eight).ToList() } }
    };

    public static HandTemplate PairOfNines { get; } = new HandTemplate
    {
        Name = "Pair of Nines",
        Hand = Hands.Pair,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 2, Cards = Cards.All.WhereRank(Ranks.Nine).ToList() } }
    };

    public static HandTemplate PairOfTens { get; } = new HandTemplate
    {
        Name = "Pair of Tens",
        Hand = Hands.Pair,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 2, Cards = Cards.All.WhereRank(Ranks.Ten).ToList() } }
    };

    public static HandTemplate PairOfJacks { get; } = new HandTemplate
    {
        Name = "Pair of Jacks",
        Hand = Hands.Pair,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 2, Cards = Cards.All.WhereRank(Ranks.Jack).ToList() } }
    };

    public static HandTemplate PairOfQueens { get; } = new HandTemplate
    {
        Name = "Pair of Queens",
        Hand = Hands.Pair,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 2, Cards = Cards.All.WhereRank(Ranks.Queen).ToList() } }
    };

    public static HandTemplate PairOfKings { get; } = new HandTemplate
    {
        Name = "Pair of Kings",
        Hand = Hands.Pair,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 2, Cards = Cards.All.WhereRank(Ranks.King).ToList() } }
    };

    public static HandTemplate PairOfAces { get; } = new HandTemplate
    {
        Name = "Pair of Aces",
        Hand = Hands.Pair,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup> { new() { Count = 2, Cards = Cards.All.WhereRank(Ranks.Ace).ToList() } }
    };

    public static List<HandTemplate> AllPairs { get; } = new()
    {
        PairOfTwos,
        PairOfThrees,
        PairOfFours,
        PairOfFives,
        PairOfSixes,
        PairOfSevens,
        PairOfEights,
        PairOfNines,
        PairOfTens,
        PairOfJacks,
        PairOfQueens,
        PairOfKings,
        PairOfAces
    };
}
