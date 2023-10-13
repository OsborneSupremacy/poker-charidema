namespace Poker.Domain.Classic.HandRequirements;

public record RoyalFlush
{
    public static HandRequirement Spades { get; } = new HandRequirement
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

    public static HandRequirement Hearts { get; } = new HandRequirement
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

    public static HandRequirement Diamonds { get; } = new HandRequirement
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

    public static HandRequirement Clubs { get; } = new HandRequirement
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

    public static List<HandRequirement> All { get; } = new()
    {
        Spades,
        Hearts,
        Diamonds,
        Clubs
    };
}
