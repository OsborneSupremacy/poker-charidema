namespace Poker.Domain.Classic;

public partial record Hands
{
    public static Hand SixHighSpadesStraightFlush { get; } = new Hand
    {
        Name = "Six High Spades Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Six,
        Suit = Suits.Spades,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.SixOfSpades,
                    Cards.FiveOfSpades,
                    Cards.FourOfSpades,
                    Cards.ThreeOfSpades,
                    Cards.TwoOfSpades
                }
            }
        }
    };

    public static Hand SevenHighSpadesStraightFlush { get; } = new Hand
    {
        Name = "Seven High Spades Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Seven,
        Suit = Suits.Spades,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.SevenOfSpades,
                    Cards.SixOfSpades,
                    Cards.FiveOfSpades,
                    Cards.FourOfSpades,
                    Cards.ThreeOfSpades
                }
            }
        }
    };

    public static Hand EightHighSpadesStraightFlush { get; } = new Hand
    {
        Name = "Eight High Spades Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Eight,
        Suit = Suits.Spades,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.EightOfSpades,
                    Cards.SevenOfSpades,
                    Cards.SixOfSpades,
                    Cards.FiveOfSpades,
                    Cards.FourOfSpades
                }
            }
        }
    };

    public static Hand NineHighSpadesStraightFlush { get; } = new Hand
    {
        Name = "Nine High Spades Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Nine,
        Suit = Suits.Spades,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.NineOfSpades,
                    Cards.EightOfSpades,
                    Cards.SevenOfSpades,
                    Cards.SixOfSpades,
                    Cards.FiveOfSpades
                }
            }
        }
    };

    public static Hand TenHighSpadesStraightFlush { get; } = new Hand
    {
        Name = "Ten High Spades Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Ten,
        Suit = Suits.Spades,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.TenOfSpades,
                    Cards.NineOfSpades,
                    Cards.EightOfSpades,
                    Cards.SevenOfSpades,
                    Cards.SixOfSpades
                }
            }
        }
    };

    public static Hand JackHighSpadesStraightFlush { get; } = new Hand
    {
        Name = "Jack High Spades Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Jack,
        Suit = Suits.Spades,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.JackOfSpades,
                    Cards.TenOfSpades,
                    Cards.NineOfSpades,
                    Cards.EightOfSpades,
                    Cards.SevenOfSpades
                }
            }
        }
    };

    public static Hand QueenHighSpadesStraightFlush { get; } = new Hand
    {
        Name = "Queen High Spades Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Queen,
        Suit = Suits.Spades,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.QueenOfSpades,
                    Cards.JackOfSpades,
                    Cards.TenOfSpades,
                    Cards.NineOfSpades,
                    Cards.EightOfSpades
                }
            }
        }
    };

    public static Hand KingHighSpadesStraightFlush { get; } = new Hand
    {
        Name = "King High Spades Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.King,
        Suit = Suits.Spades,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.KingOfSpades,
                    Cards.QueenOfSpades,
                    Cards.JackOfSpades,
                    Cards.TenOfSpades,
                    Cards.NineOfSpades
                }
            }
        }
    };

    public static Hand SixHighHeartsStraightFlush { get; } = new Hand
    {
        Name = "Six High Hearts Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Six,
        Suit = Suits.Hearts,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.SixOfHearts,
                    Cards.FiveOfHearts,
                    Cards.FourOfHearts,
                    Cards.ThreeOfHearts,
                    Cards.TwoOfHearts
                }
            }
        }
    };

    public static Hand SevenHighHeartsStraightFlush { get; } = new Hand
    {
        Name = "Seven High Hearts Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Seven,
        Suit = Suits.Hearts,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.SevenOfHearts,
                    Cards.SixOfHearts,
                    Cards.FiveOfHearts,
                    Cards.FourOfHearts,
                    Cards.ThreeOfHearts
                }
            }
        }
    };

    public static Hand EightHighHeartsStraightFlush { get; } = new Hand
    {
        Name = "Eight High Hearts Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Eight,
        Suit = Suits.Hearts,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.EightOfHearts,
                    Cards.SevenOfHearts,
                    Cards.SixOfHearts,
                    Cards.FiveOfHearts,
                    Cards.FourOfHearts
                }
            }
        }
    };

    public static Hand NineHighHeartsStraightFlush { get; } = new Hand
    {
        Name = "Nine High Hearts Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Nine,
        Suit = Suits.Hearts,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.NineOfHearts,
                    Cards.EightOfHearts,
                    Cards.SevenOfHearts,
                    Cards.SixOfHearts,
                    Cards.FiveOfHearts
                }
            }
        }
    };

    public static Hand TenHighHeartsStraightFlush { get; } = new Hand
    {
        Name = "Ten High Hearts Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Ten,
        Suit = Suits.Hearts,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.TenOfHearts,
                    Cards.NineOfHearts,
                    Cards.EightOfHearts,
                    Cards.SevenOfHearts,
                    Cards.SixOfHearts
                }
            }
        }
    };

    public static Hand JackHighHeartsStraightFlush { get; } = new Hand
    {
        Name = "Jack High Hearts Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Jack,
        Suit = Suits.Hearts,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.JackOfHearts,
                    Cards.TenOfHearts,
                    Cards.NineOfHearts,
                    Cards.EightOfHearts,
                    Cards.SevenOfHearts
                }
            }
        }
    };

    public static Hand QueenHighHeartsStraightFlush { get; } = new Hand
    {
        Name = "Queen High Hearts Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Queen,
        Suit = Suits.Hearts,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.QueenOfHearts,
                    Cards.JackOfHearts,
                    Cards.TenOfHearts,
                    Cards.NineOfHearts,
                    Cards.EightOfHearts
                }
            }
        }
    };

    public static Hand KingHighHeartsStraightFlush { get; } = new Hand
    {
        Name = "King High Hearts Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.King,
        Suit = Suits.Hearts,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.KingOfHearts,
                    Cards.QueenOfHearts,
                    Cards.JackOfHearts,
                    Cards.TenOfHearts,
                    Cards.NineOfHearts
                }
            }
        }
    };

    public static Hand SixHighClubsStraightFlush { get; } = new Hand
    {
        Name = "Six High Clubs Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Six,
        Suit = Suits.Clubs,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.SixOfClubs,
                    Cards.FiveOfClubs,
                    Cards.FourOfClubs,
                    Cards.ThreeOfClubs,
                    Cards.TwoOfClubs
                }
            }
        }
    };

    public static Hand SevenHighClubsStraightFlush { get; } = new Hand
    {
        Name = "Seven High Clubs Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Seven,
        Suit = Suits.Clubs,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.SevenOfClubs,
                    Cards.SixOfClubs,
                    Cards.FiveOfClubs,
                    Cards.FourOfClubs,
                    Cards.ThreeOfClubs
                }
            }
        }
    };

    public static Hand EightHighClubsStraightFlush { get; } = new Hand
    {
        Name = "Eight High Clubs Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Eight,
        Suit = Suits.Clubs,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.EightOfClubs,
                    Cards.SevenOfClubs,
                    Cards.SixOfClubs,
                    Cards.FiveOfClubs,
                    Cards.FourOfClubs
                }
            }
        }
    };

    public static Hand NineHighClubsStraightFlush { get; } = new Hand
    {
        Name = "Nine High Clubs Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Nine,
        Suit = Suits.Clubs,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.NineOfClubs,
                    Cards.EightOfClubs,
                    Cards.SevenOfClubs,
                    Cards.SixOfClubs,
                    Cards.FiveOfClubs
                }
            }
        }
    };

    public static Hand TenHighClubsStraightFlush { get; } = new Hand
    {
        Name = "Ten High Clubs Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Ten,
        Suit = Suits.Clubs,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.TenOfClubs,
                    Cards.NineOfClubs,
                    Cards.EightOfClubs,
                    Cards.SevenOfClubs,
                    Cards.SixOfClubs
                }
            }
        }
    };

    public static Hand JackHighClubsStraightFlush { get; } = new Hand
    {
        Name = "Jack High Clubs Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Jack,
        Suit = Suits.Clubs,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.JackOfClubs,
                    Cards.TenOfClubs,
                    Cards.NineOfClubs,
                    Cards.EightOfClubs,
                    Cards.SevenOfClubs
                }
            }
        }
    };

    public static Hand QueenHighClubsStraightFlush { get; } = new Hand
    {
        Name = "Queen High Clubs Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Queen,
        Suit = Suits.Clubs,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.QueenOfClubs,
                    Cards.JackOfClubs,
                    Cards.TenOfClubs,
                    Cards.NineOfClubs,
                    Cards.EightOfClubs
                }
            }
        }
    };

    public static Hand KingHighClubsStraightFlush { get; } = new Hand
    {
        Name = "King High Clubs Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.King,
        Suit = Suits.Clubs,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.KingOfClubs,
                    Cards.QueenOfClubs,
                    Cards.JackOfClubs,
                    Cards.TenOfClubs,
                    Cards.NineOfClubs
                }
            }
        }
    };

    public static Hand SixHighDiamondsStraightFlush { get; } = new Hand
    {
        Name = "Six High Diamonds Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Six,
        Suit = Suits.Diamonds,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.SixOfDiamonds,
                    Cards.FiveOfDiamonds,
                    Cards.FourOfDiamonds,
                    Cards.ThreeOfDiamonds,
                    Cards.TwoOfDiamonds
                }
            }
        }
    };

    public static Hand SevenHighDiamondsStraightFlush { get; } = new Hand
    {
        Name = "Seven High Diamonds Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Seven,
        Suit = Suits.Diamonds,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.SevenOfDiamonds,
                    Cards.SixOfDiamonds,
                    Cards.FiveOfDiamonds,
                    Cards.FourOfDiamonds,
                    Cards.ThreeOfDiamonds
                }
            }
        }
    };

    public static Hand EightHighDiamondsStraightFlush { get; } = new Hand
    {
        Name = "Eight High Diamonds Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Eight,
        Suit = Suits.Diamonds,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.EightOfDiamonds,
                    Cards.SevenOfDiamonds,
                    Cards.SixOfDiamonds,
                    Cards.FiveOfDiamonds,
                    Cards.FourOfDiamonds
                }
            }
        }
    };

    public static Hand NineHighDiamondsStraightFlush { get; } = new Hand
    {
        Name = "Nine High Diamonds Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Nine,
        Suit = Suits.Diamonds,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.NineOfDiamonds,
                    Cards.EightOfDiamonds,
                    Cards.SevenOfDiamonds,
                    Cards.SixOfDiamonds,
                    Cards.FiveOfDiamonds
                }
            }
        }
    };

    public static Hand TenHighDiamondsStraightFlush { get; } = new Hand
    {
        Name = "Ten High Diamonds Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Ten,
        Suit = Suits.Diamonds,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.TenOfDiamonds,
                    Cards.NineOfDiamonds,
                    Cards.EightOfDiamonds,
                    Cards.SevenOfDiamonds,
                    Cards.SixOfDiamonds
                }
            }
        }
    };

    public static Hand JackHighDiamondsStraightFlush { get; } = new Hand
    {
        Name = "Jack High Diamonds Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Jack,
        Suit = Suits.Diamonds,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.JackOfDiamonds,
                    Cards.TenOfDiamonds,
                    Cards.NineOfDiamonds,
                    Cards.EightOfDiamonds,
                    Cards.SevenOfDiamonds
                }
            }
        }
    };

    public static Hand QueenHighDiamondsStraightFlush { get; } = new Hand
    {
        Name = "Queen High Diamonds Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Queen,
        Suit = Suits.Diamonds,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.QueenOfDiamonds,
                    Cards.JackOfDiamonds,
                    Cards.TenOfDiamonds,
                    Cards.NineOfDiamonds,
                    Cards.EightOfDiamonds
                }
            }
        }
    };

    public static Hand KingHighDiamondsStraightFlush { get; } = new Hand
    {
        Name = "King High Diamonds Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.King,
        Suit = Suits.Diamonds,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.KingOfDiamonds,
                    Cards.QueenOfDiamonds,
                    Cards.JackOfDiamonds,
                    Cards.TenOfDiamonds,
                    Cards.NineOfDiamonds
                }
            }
        }
    };

    public static List<Hand> AllStraightFlushes { get; } = new()
    {
        SixHighSpadesStraightFlush,
        SevenHighSpadesStraightFlush,
        EightHighSpadesStraightFlush,
        NineHighSpadesStraightFlush,
        TenHighSpadesStraightFlush,
        JackHighSpadesStraightFlush,
        QueenHighSpadesStraightFlush,
        KingHighSpadesStraightFlush,
        SixHighHeartsStraightFlush,
        SevenHighHeartsStraightFlush,
        EightHighHeartsStraightFlush,
        NineHighHeartsStraightFlush,
        TenHighHeartsStraightFlush,
        JackHighHeartsStraightFlush,
        QueenHighHeartsStraightFlush,
        KingHighHeartsStraightFlush,
        SixHighClubsStraightFlush,
        SevenHighClubsStraightFlush,
        EightHighClubsStraightFlush,
        NineHighClubsStraightFlush,
        TenHighClubsStraightFlush,
        JackHighClubsStraightFlush,
        QueenHighClubsStraightFlush,
        KingHighClubsStraightFlush,
        SixHighDiamondsStraightFlush,
        SevenHighDiamondsStraightFlush,
        EightHighDiamondsStraightFlush,
        NineHighDiamondsStraightFlush,
        TenHighDiamondsStraightFlush,
        JackHighDiamondsStraightFlush,
        QueenHighDiamondsStraightFlush,
        KingHighDiamondsStraightFlush
    };

}
