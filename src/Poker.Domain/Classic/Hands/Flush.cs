namespace Poker.Domain.Classic;

public partial record Hands
{
    public static Hand SpadesFlush { get; } = new Hand
    {
        Name = "Spades Flush",
        HandDefinition = HandDefinitions.Flush,
        HighRank = Ranks.Empty,
        Suit = Suits.Spades,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 5,
                Cards = Cards.All.WhereSuit(Suits.Spades).ToList()
            }
        }
    };

    public static Hand HeartsFlush { get; } = new Hand
    {
        Name = "Hearts Flush",
        HandDefinition = HandDefinitions.Flush,
        HighRank = Ranks.Empty,
        Suit = Suits.Hearts,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 5,
                Cards = Cards.All.WhereSuit(Suits.Hearts).ToList()
            }
        }
    };

    public static Hand DiamondsFlush { get; } = new Hand
    {
        Name = "Diamonds Flush",
        HandDefinition = HandDefinitions.Flush,
        HighRank = Ranks.Empty,
        Suit = Suits.Diamonds,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 5,
                Cards = Cards.All.WhereSuit(Suits.Diamonds).ToList()
            }
        }
    };

    public static Hand ClubsFlush { get; } = new Hand
    {
        Name = "Clubs Flush",
        HandDefinition = HandDefinitions.Flush,
        HighRank = Ranks.Empty,
        Suit = Suits.Clubs,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 5,
                Cards = Cards.All.WhereSuit(Suits.Clubs).ToList()
            }
        }
    };

    public static List<Hand> AllFlushes { get; } = new()
    {
        SpadesFlush,
        HeartsFlush,
        ClubsFlush,
        DiamondsFlush
    };
}
