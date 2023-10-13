namespace Poker.Domain.Classic;

public partial record HandTemplates
{
    public static HandTemplate SpadesRoyalFlush { get; } = new HandTemplate
    {
        Name = "Spades Royal Flush",
        Hand = Hands.RoyalFlush,
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

    public static HandTemplate HeartsRoyalFlush { get; } = new HandTemplate
    {
        Name = "Hearts Royal Flush",
        Hand = Hands.RoyalFlush,
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

    public static HandTemplate DiamondsRoyalFlush { get; } = new HandTemplate
    {
        Name = "Diamonds Royal Flush",
        Hand = Hands.RoyalFlush,
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

    public static HandTemplate ClubsRoyalFlush { get; } = new HandTemplate
    {
        Name = "Clubs Royal Flush",
        Hand = Hands.RoyalFlush,
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

    public static List<HandTemplate> AllRoyalFlushes { get; } = new()
    {
        SpadesRoyalFlush,
        HeartsRoyalFlush,
        DiamondsRoyalFlush,
        ClubsRoyalFlush
    };
}
