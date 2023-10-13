namespace Poker.Domain.Classic;

public partial record Hands
{
    public static Hand SpadesRoyalFlush { get; } = new Hand
    {
        Name = "Spades Royal Flush",
        HandDefinition = HandDefinitions.RoyalFlush,
        HighRank = Ranks.Ace,
        Suit = Suits.Spades,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 5,
                Cards = new()
                {
                    Cards.TenOfSpades,
                    Cards.JackOfSpades,
                    Cards.QueenOfSpades,
                    Cards.KingOfSpades,
                    Cards.AceOfSpades
                }
            }
        }
    };

    public static Hand HeartsRoyalFlush { get; } = new Hand
    {
        Name = "Hearts Royal Flush",
        HandDefinition = HandDefinitions.RoyalFlush,
        HighRank = Ranks.Ace,
        Suit = Suits.Hearts,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 5,
                Cards = new()
                {
                    Cards.TenOfHearts,
                    Cards.JackOfHearts,
                    Cards.QueenOfHearts,
                    Cards.KingOfHearts,
                    Cards.AceOfHearts
                }
            }
        }
    };

    public static Hand DiamondsRoyalFlush { get; } = new Hand
    {
        Name = "Diamonds Royal Flush",
        HandDefinition = HandDefinitions.RoyalFlush,
        HighRank = Ranks.Ace,
        Suit = Suits.Diamonds,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 5,
                Cards = new()
                {
                    Cards.TenOfDiamonds,
                    Cards.JackOfDiamonds,
                    Cards.QueenOfDiamonds,
                    Cards.KingOfDiamonds,
                    Cards.AceOfDiamonds
                }
            }
        }
    };

    public static Hand ClubsRoyalFlush { get; } = new Hand
    {
        Name = "Clubs Royal Flush",
        HandDefinition = HandDefinitions.RoyalFlush,
        HighRank = Ranks.Ace,
        Suit = Suits.Clubs,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 5,
                Cards = new()
                {
                    Cards.TenOfClubs,
                    Cards.JackOfClubs,
                    Cards.QueenOfClubs,
                    Cards.KingOfClubs,
                    Cards.AceOfClubs
                }
            }
        }
    };

    public static List<Hand> AllRoyalFlushes { get; } = new()
    {
        SpadesRoyalFlush,
        HeartsRoyalFlush,
        DiamondsRoyalFlush,
        ClubsRoyalFlush
    };
}
