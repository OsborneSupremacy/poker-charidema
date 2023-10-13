namespace Poker.Domain.Classic;

public partial record HandTemplates
{
    public static HandTemplate SpadesFlush { get; } = new HandTemplate
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

    public static HandTemplate HeartsFlush { get; } = new HandTemplate
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

    public static HandTemplate DiamondsFlush { get; } = new HandTemplate
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

    public static HandTemplate ClubsFlush { get; } = new HandTemplate
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

    public static List<HandTemplate> AllFlushes { get; } = new()
    {
        SpadesFlush,
        HeartsFlush,
        ClubsFlush,
        DiamondsFlush
    };
}
