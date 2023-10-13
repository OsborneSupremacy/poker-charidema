namespace Poker.Domain.Classic.HandRequirements;

public class Flush
{
    public static HandRequirement Spades { get; } = new HandRequirement
    {
        Name = nameof(Spades),
        Hand = Hands.Flush,
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

    public static HandRequirement Hearts { get; } = new HandRequirement
    {
        Name = nameof(Hearts),
        Hand = Hands.Flush,
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

    public static HandRequirement Diamonds { get; } = new HandRequirement
    {
        Name = nameof(Diamonds),
        Hand = Hands.Flush,
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

    public static HandRequirement Clubs { get; } = new HandRequirement
    {
        Name = nameof(Clubs),
        Hand = Hands.Flush,
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
}
