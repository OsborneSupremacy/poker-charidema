namespace Poker.Domain.Classic.Hands;

public static class StraightFlushes
{
    public static Hand SixHighSpades { get; } = new()
    {
        Name = "Six High Spades Straight Flush",
        HandDefinition = HandDefinitions.StraightFlush,
        HighRank = Ranks.Six,
        Suit = Suits.Spades,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.SixOfSpades,
                    Cards.FiveOfSpades,
                    Cards.FourOfSpades,
                    Cards.ThreeOfSpades,
                    Cards.TwoOfSpades
                ]
            }
        ]
    };

    public static Hand SevenHighSpades { get; } = new()
    {
        Name = "Seven High Spades Straight Flush",
        HandDefinition = HandDefinitions.StraightFlush,
        HighRank = Ranks.Seven,
        Suit = Suits.Spades,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.SevenOfSpades,
                    Cards.SixOfSpades,
                    Cards.FiveOfSpades,
                    Cards.FourOfSpades,
                    Cards.ThreeOfSpades
                ]
            }
        ]
    };

    public static Hand EightHighSpades { get; } = new()
    {
        Name = "Eight High Spades Straight Flush",
        HandDefinition = HandDefinitions.StraightFlush,
        HighRank = Ranks.Eight,
        Suit = Suits.Spades,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.EightOfSpades,
                    Cards.SevenOfSpades,
                    Cards.SixOfSpades,
                    Cards.FiveOfSpades,
                    Cards.FourOfSpades
                ]
            }
        ]
    };

    public static Hand NineHighSpades { get; } = new()
    {
        Name = "Nine High Spades Straight Flush",
        HandDefinition = HandDefinitions.StraightFlush,
        HighRank = Ranks.Nine,
        Suit = Suits.Spades,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.NineOfSpades,
                    Cards.EightOfSpades,
                    Cards.SevenOfSpades,
                    Cards.SixOfSpades,
                    Cards.FiveOfSpades
                ]
            }
        ]
    };

    public static Hand TenHighSpades { get; } = new()
    {
        Name = "Ten High Spades Straight Flush",
        HandDefinition = HandDefinitions.StraightFlush,
        HighRank = Ranks.Ten,
        Suit = Suits.Spades,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.TenOfSpades,
                    Cards.NineOfSpades,
                    Cards.EightOfSpades,
                    Cards.SevenOfSpades,
                    Cards.SixOfSpades
                ]
            }
        ]
    };

    public static Hand JackHighSpades { get; } = new()
    {
        Name = "Jack High Spades Straight Flush",
        HandDefinition = HandDefinitions.StraightFlush,
        HighRank = Ranks.Jack,
        Suit = Suits.Spades,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.JackOfSpades,
                    Cards.TenOfSpades,
                    Cards.NineOfSpades,
                    Cards.EightOfSpades,
                    Cards.SevenOfSpades
                ]
            }
        ]
    };

    public static Hand QueenHighSpades { get; } = new()
    {
        Name = "Queen High Spades Straight Flush",
        HandDefinition = HandDefinitions.StraightFlush,
        HighRank = Ranks.Queen,
        Suit = Suits.Spades,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.QueenOfSpades,
                    Cards.JackOfSpades,
                    Cards.TenOfSpades,
                    Cards.NineOfSpades,
                    Cards.EightOfSpades
                ]
            }
        ]
    };

    public static Hand KingHighSpades { get; } = new()
    {
        Name = "King High Spades Straight Flush",
        HandDefinition = HandDefinitions.StraightFlush,
        HighRank = Ranks.King,
        Suit = Suits.Spades,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.KingOfSpades,
                    Cards.QueenOfSpades,
                    Cards.JackOfSpades,
                    Cards.TenOfSpades,
                    Cards.NineOfSpades
                ]
            }
        ]
    };

    public static Hand SixHighHearts { get; } = new()
    {
        Name = "Six High Hearts Straight Flush",
        HandDefinition = HandDefinitions.StraightFlush,
        HighRank = Ranks.Six,
        Suit = Suits.Hearts,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.SixOfHearts,
                    Cards.FiveOfHearts,
                    Cards.FourOfHearts,
                    Cards.ThreeOfHearts,
                    Cards.TwoOfHearts
                ]
            }
        ]
    };

    public static Hand SevenHighHearts { get; } = new()
    {
        Name = "Seven High Hearts Straight Flush",
        HandDefinition = HandDefinitions.StraightFlush,
        HighRank = Ranks.Seven,
        Suit = Suits.Hearts,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.SevenOfHearts,
                    Cards.SixOfHearts,
                    Cards.FiveOfHearts,
                    Cards.FourOfHearts,
                    Cards.ThreeOfHearts
                ]
            }
        ]
    };

    public static Hand EightHighHearts { get; } = new()
    {
        Name = "Eight High Hearts Straight Flush",
        HandDefinition = HandDefinitions.StraightFlush,
        HighRank = Ranks.Eight,
        Suit = Suits.Hearts,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.EightOfHearts,
                    Cards.SevenOfHearts,
                    Cards.SixOfHearts,
                    Cards.FiveOfHearts,
                    Cards.FourOfHearts
                ]
            }
        ]
    };

    public static Hand NineHighHearts { get; } = new()
    {
        Name = "Nine High Hearts Straight Flush",
        HandDefinition = HandDefinitions.StraightFlush,
        HighRank = Ranks.Nine,
        Suit = Suits.Hearts,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.NineOfHearts,
                    Cards.EightOfHearts,
                    Cards.SevenOfHearts,
                    Cards.SixOfHearts,
                    Cards.FiveOfHearts
                ]
            }
        ]
    };

    public static Hand TenHighHearts { get; } = new()
    {
        Name = "Ten High Hearts Straight Flush",
        HandDefinition = HandDefinitions.StraightFlush,
        HighRank = Ranks.Ten,
        Suit = Suits.Hearts,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.TenOfHearts,
                    Cards.NineOfHearts,
                    Cards.EightOfHearts,
                    Cards.SevenOfHearts,
                    Cards.SixOfHearts
                ]
            }
        ]
    };

    public static Hand JackHighHearts { get; } = new()
    {
        Name = "Jack High Hearts Straight Flush",
        HandDefinition = HandDefinitions.StraightFlush,
        HighRank = Ranks.Jack,
        Suit = Suits.Hearts,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.JackOfHearts,
                    Cards.TenOfHearts,
                    Cards.NineOfHearts,
                    Cards.EightOfHearts,
                    Cards.SevenOfHearts
                ]
            }
        ]
    };

    public static Hand QueenHighHearts { get; } = new()
    {
        Name = "Queen High Hearts Straight Flush",
        HandDefinition = HandDefinitions.StraightFlush,
        HighRank = Ranks.Queen,
        Suit = Suits.Hearts,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.QueenOfHearts,
                    Cards.JackOfHearts,
                    Cards.TenOfHearts,
                    Cards.NineOfHearts,
                    Cards.EightOfHearts
                ]
            }
        ]
    };

    public static Hand KingHighHearts { get; } = new()
    {
        Name = "King High Hearts Straight Flush",
        HandDefinition = HandDefinitions.StraightFlush,
        HighRank = Ranks.King,
        Suit = Suits.Hearts,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.KingOfHearts,
                    Cards.QueenOfHearts,
                    Cards.JackOfHearts,
                    Cards.TenOfHearts,
                    Cards.NineOfHearts
                ]
            }
        ]
    };

    public static Hand SixHighClubs { get; } = new()
    {
        Name = "Six High Clubs Straight Flush",
        HandDefinition = HandDefinitions.StraightFlush,
        HighRank = Ranks.Six,
        Suit = Suits.Clubs,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.SixOfClubs,
                    Cards.FiveOfClubs,
                    Cards.FourOfClubs,
                    Cards.ThreeOfClubs,
                    Cards.TwoOfClubs
                ]
            }
        ]
    };

    public static Hand SevenHighClubs { get; } = new()
    {
        Name = "Seven High Clubs Straight Flush",
        HandDefinition = HandDefinitions.StraightFlush,
        HighRank = Ranks.Seven,
        Suit = Suits.Clubs,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.SevenOfClubs,
                    Cards.SixOfClubs,
                    Cards.FiveOfClubs,
                    Cards.FourOfClubs,
                    Cards.ThreeOfClubs
                ]
            }
        ]
    };

    public static Hand EightHighClubs { get; } = new()
    {
        Name = "Eight High Clubs Straight Flush",
        HandDefinition = HandDefinitions.StraightFlush,
        HighRank = Ranks.Eight,
        Suit = Suits.Clubs,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.EightOfClubs,
                    Cards.SevenOfClubs,
                    Cards.SixOfClubs,
                    Cards.FiveOfClubs,
                    Cards.FourOfClubs
                ]
            }
        ]
    };

    public static Hand NineHighClubs { get; } = new()
    {
        Name = "Nine High Clubs Straight Flush",
        HandDefinition = HandDefinitions.StraightFlush,
        HighRank = Ranks.Nine,
        Suit = Suits.Clubs,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.NineOfClubs,
                    Cards.EightOfClubs,
                    Cards.SevenOfClubs,
                    Cards.SixOfClubs,
                    Cards.FiveOfClubs
                ]
            }
        ]
    };

    public static Hand TenHighClubs { get; } = new()
    {
        Name = "Ten High Clubs Straight Flush",
        HandDefinition = HandDefinitions.StraightFlush,
        HighRank = Ranks.Ten,
        Suit = Suits.Clubs,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.TenOfClubs,
                    Cards.NineOfClubs,
                    Cards.EightOfClubs,
                    Cards.SevenOfClubs,
                    Cards.SixOfClubs
                ]
            }
        ]
    };

    public static Hand JackHighClubs { get; } = new()
    {
        Name = "Jack High Clubs Straight Flush",
        HandDefinition = HandDefinitions.StraightFlush,
        HighRank = Ranks.Jack,
        Suit = Suits.Clubs,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.JackOfClubs,
                    Cards.TenOfClubs,
                    Cards.NineOfClubs,
                    Cards.EightOfClubs,
                    Cards.SevenOfClubs
                ]
            }
        ]
    };

    public static Hand QueenHighClubs { get; } = new()
    {
        Name = "Queen High Clubs Straight Flush",
        HandDefinition = HandDefinitions.StraightFlush,
        HighRank = Ranks.Queen,
        Suit = Suits.Clubs,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.QueenOfClubs,
                    Cards.JackOfClubs,
                    Cards.TenOfClubs,
                    Cards.NineOfClubs,
                    Cards.EightOfClubs
                ]
            }
        ]
    };

    public static Hand KingHighClubs { get; } = new()
    {
        Name = "King High Clubs Straight Flush",
        HandDefinition = HandDefinitions.StraightFlush,
        HighRank = Ranks.King,
        Suit = Suits.Clubs,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.KingOfClubs,
                    Cards.QueenOfClubs,
                    Cards.JackOfClubs,
                    Cards.TenOfClubs,
                    Cards.NineOfClubs
                ]
            }
        ]
    };

    public static Hand SixHighDiamonds { get; } = new()
    {
        Name = "Six High Diamonds Straight Flush",
        HandDefinition = HandDefinitions.StraightFlush,
        HighRank = Ranks.Six,
        Suit = Suits.Diamonds,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.SixOfDiamonds,
                    Cards.FiveOfDiamonds,
                    Cards.FourOfDiamonds,
                    Cards.ThreeOfDiamonds,
                    Cards.TwoOfDiamonds
                ]
            }
        ]
    };

    public static Hand SevenHighDiamonds { get; } = new()
    {
        Name = "Seven High Diamonds Straight Flush",
        HandDefinition = HandDefinitions.StraightFlush,
        HighRank = Ranks.Seven,
        Suit = Suits.Diamonds,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.SevenOfDiamonds,
                    Cards.SixOfDiamonds,
                    Cards.FiveOfDiamonds,
                    Cards.FourOfDiamonds,
                    Cards.ThreeOfDiamonds
                ]
            }
        ]
    };

    public static Hand EightHighDiamonds { get; } = new()
    {
        Name = "Eight High Diamonds Straight Flush",
        HandDefinition = HandDefinitions.StraightFlush,
        HighRank = Ranks.Eight,
        Suit = Suits.Diamonds,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.EightOfDiamonds,
                    Cards.SevenOfDiamonds,
                    Cards.SixOfDiamonds,
                    Cards.FiveOfDiamonds,
                    Cards.FourOfDiamonds
                ]
            }
        ]
    };

    public static Hand NineHighDiamonds { get; } = new()
    {
        Name = "Nine High Diamonds Straight Flush",
        HandDefinition = HandDefinitions.StraightFlush,
        HighRank = Ranks.Nine,
        Suit = Suits.Diamonds,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.NineOfDiamonds,
                    Cards.EightOfDiamonds,
                    Cards.SevenOfDiamonds,
                    Cards.SixOfDiamonds,
                    Cards.FiveOfDiamonds
                ]
            }
        ]
    };

    public static Hand TenHighDiamonds { get; } = new()
    {
        Name = "Ten High Diamonds Straight Flush",
        HandDefinition = HandDefinitions.StraightFlush,
        HighRank = Ranks.Ten,
        Suit = Suits.Diamonds,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.TenOfDiamonds,
                    Cards.NineOfDiamonds,
                    Cards.EightOfDiamonds,
                    Cards.SevenOfDiamonds,
                    Cards.SixOfDiamonds
                ]
            }
        ]
    };

    public static Hand JackHighDiamonds { get; } = new()
    {
        Name = "Jack High Diamonds Straight Flush",
        HandDefinition = HandDefinitions.StraightFlush,
        HighRank = Ranks.Jack,
        Suit = Suits.Diamonds,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.JackOfDiamonds,
                    Cards.TenOfDiamonds,
                    Cards.NineOfDiamonds,
                    Cards.EightOfDiamonds,
                    Cards.SevenOfDiamonds
                ]
            }
        ]
    };

    public static Hand QueenHighDiamonds { get; } = new()
    {
        Name = "Queen High Diamonds Straight Flush",
        HandDefinition = HandDefinitions.StraightFlush,
        HighRank = Ranks.Queen,
        Suit = Suits.Diamonds,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.QueenOfDiamonds,
                    Cards.JackOfDiamonds,
                    Cards.TenOfDiamonds,
                    Cards.NineOfDiamonds,
                    Cards.EightOfDiamonds
                ]
            }
        ]
    };

    public static Hand KingHighDiamonds { get; } = new()
    {
        Name = "King High Diamonds Straight Flush",
        HandDefinition = HandDefinitions.StraightFlush,
        HighRank = Ranks.King,
        Suit = Suits.Diamonds,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.KingOfDiamonds,
                    Cards.QueenOfDiamonds,
                    Cards.JackOfDiamonds,
                    Cards.TenOfDiamonds,
                    Cards.NineOfDiamonds
                ]
            }
        ]
    };

}
