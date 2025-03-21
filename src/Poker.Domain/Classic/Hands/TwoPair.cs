﻿namespace Poker.Domain.Classic.Hands;

public static class TwoPair
{
    public static Hand ThreesOverTwos { get; } = new()
    {
        Name = "Threes Over Twos",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Three,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.ThreeOfSpades, Cards.ThreeOfHearts, Cards.ThreeOfClubs, Cards.ThreeOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.TwoOfSpades, Cards.TwoOfHearts, Cards.TwoOfClubs, Cards.TwoOfDiamonds]
            }
        ]
    };

    public static Hand FoursOverTwos { get; } = new()
    {
        Name = "Fours Over Twos",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Four,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.FourOfSpades, Cards.FourOfHearts, Cards.FourOfClubs, Cards.FourOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.TwoOfSpades, Cards.TwoOfHearts, Cards.TwoOfClubs, Cards.TwoOfDiamonds]
            }
        ]
    };

    public static Hand FoursOverThrees { get; } = new()
    {
        Name = "Fours Over Threes",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Four,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.FourOfSpades, Cards.FourOfHearts, Cards.FourOfClubs, Cards.FourOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.ThreeOfSpades, Cards.ThreeOfHearts, Cards.ThreeOfClubs, Cards.ThreeOfDiamonds]
            }
        ]
    };

    public static Hand FivesOverTwos { get; } = new()
    {
        Name = "Fives Over Twos",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Five,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.FiveOfSpades, Cards.FiveOfHearts, Cards.FiveOfClubs, Cards.FiveOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.TwoOfSpades, Cards.TwoOfHearts, Cards.TwoOfClubs, Cards.TwoOfDiamonds]
            }
        ]
    };

    public static Hand FivesOverThrees { get; } = new()
    {
        Name = "Fives Over Threes",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Five,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.FiveOfSpades, Cards.FiveOfHearts, Cards.FiveOfClubs, Cards.FiveOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.ThreeOfSpades, Cards.ThreeOfHearts, Cards.ThreeOfClubs, Cards.ThreeOfDiamonds]
            }
        ]
    };

    public static Hand FivesOverFours { get; } = new()
    {
        Name = "Fives Over Fours",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Five,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.FiveOfSpades, Cards.FiveOfHearts, Cards.FiveOfClubs, Cards.FiveOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.FourOfSpades, Cards.FourOfHearts, Cards.FourOfClubs, Cards.FourOfDiamonds]
            }
        ]
    };

    public static Hand SixesOverTwos { get; } = new()
    {
        Name = "Sixes Over Twos",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.SixOfSpades, Cards.SixOfHearts, Cards.SixOfClubs, Cards.SixOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.TwoOfSpades, Cards.TwoOfHearts, Cards.TwoOfClubs, Cards.TwoOfDiamonds]
            }
        ]
    };

    public static Hand SixesOverThrees { get; } = new()
    {
        Name = "Sixes Over Threes",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.SixOfSpades, Cards.SixOfHearts, Cards.SixOfClubs, Cards.SixOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.ThreeOfSpades, Cards.ThreeOfHearts, Cards.ThreeOfClubs, Cards.ThreeOfDiamonds]
            }
        ]
    };

    public static Hand SixesOverFours { get; } = new()
    {
        Name = "Sixes Over Fours",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.SixOfSpades, Cards.SixOfHearts, Cards.SixOfClubs, Cards.SixOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.FourOfSpades, Cards.FourOfHearts, Cards.FourOfClubs, Cards.FourOfDiamonds]
            }
        ]
    };

    public static Hand SixesOverFives { get; } = new()
    {
        Name = "Sixes Over Fives",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.SixOfSpades, Cards.SixOfHearts, Cards.SixOfClubs, Cards.SixOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.FiveOfSpades, Cards.FiveOfHearts, Cards.FiveOfClubs, Cards.FiveOfDiamonds]
            }
        ]
    };

    public static Hand SevensOverTwos { get; } = new()
    {
        Name = "Sevens Over Twos",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.SevenOfSpades, Cards.SevenOfHearts, Cards.SevenOfClubs, Cards.SevenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.TwoOfSpades, Cards.TwoOfHearts, Cards.TwoOfClubs, Cards.TwoOfDiamonds]
            }
        ]
    };

    public static Hand SevensOverThrees { get; } = new()
    {
        Name = "Sevens Over Threes",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.SevenOfSpades, Cards.SevenOfHearts, Cards.SevenOfClubs, Cards.SevenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.ThreeOfSpades, Cards.ThreeOfHearts, Cards.ThreeOfClubs, Cards.ThreeOfDiamonds]
            }
        ]
    };

    public static Hand SevensOverFours { get; } = new()
    {
        Name = "Sevens Over Fours",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.SevenOfSpades, Cards.SevenOfHearts, Cards.SevenOfClubs, Cards.SevenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.FourOfSpades, Cards.FourOfHearts, Cards.FourOfClubs, Cards.FourOfDiamonds]
            }
        ]
    };

    public static Hand SevensOverFives { get; } = new()
    {
        Name = "Sevens Over Fives",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.SevenOfSpades, Cards.SevenOfHearts, Cards.SevenOfClubs, Cards.SevenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.FiveOfSpades, Cards.FiveOfHearts, Cards.FiveOfClubs, Cards.FiveOfDiamonds]
            }
        ]
    };

    public static Hand SevensOverSixes { get; } = new()
    {
        Name = "Sevens Over Sixes",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.SevenOfSpades, Cards.SevenOfHearts, Cards.SevenOfClubs, Cards.SevenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.SixOfSpades, Cards.SixOfHearts, Cards.SixOfClubs, Cards.SixOfDiamonds]
            }
        ]
    };

    public static Hand EightsOverTwos { get; } = new()
    {
        Name = "Eights Over Twos",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.EightOfSpades, Cards.EightOfHearts, Cards.EightOfClubs, Cards.EightOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.TwoOfSpades, Cards.TwoOfHearts, Cards.TwoOfClubs, Cards.TwoOfDiamonds]
            }
        ]
    };

    public static Hand EightsOverThrees { get; } = new()
    {
        Name = "Eights Over Threes",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.EightOfSpades, Cards.EightOfHearts, Cards.EightOfClubs, Cards.EightOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.ThreeOfSpades, Cards.ThreeOfHearts, Cards.ThreeOfClubs, Cards.ThreeOfDiamonds]
            }
        ]
    };

    public static Hand EightsOverFours { get; } = new()
    {
        Name = "Eights Over Fours",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.EightOfSpades, Cards.EightOfHearts, Cards.EightOfClubs, Cards.EightOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.FourOfSpades, Cards.FourOfHearts, Cards.FourOfClubs, Cards.FourOfDiamonds]
            }
        ]
    };

    public static Hand EightsOverFives { get; } = new()
    {
        Name = "Eights Over Fives",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.EightOfSpades, Cards.EightOfHearts, Cards.EightOfClubs, Cards.EightOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.FiveOfSpades, Cards.FiveOfHearts, Cards.FiveOfClubs, Cards.FiveOfDiamonds]
            }
        ]
    };

    public static Hand EightsOverSixes { get; } = new()
    {
        Name = "Eights Over Sixes",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.EightOfSpades, Cards.EightOfHearts, Cards.EightOfClubs, Cards.EightOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.SixOfSpades, Cards.SixOfHearts, Cards.SixOfClubs, Cards.SixOfDiamonds]
            }
        ]
    };

    public static Hand EightsOverSevens { get; } = new()
    {
        Name = "Eights Over Sevens",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.EightOfSpades, Cards.EightOfHearts, Cards.EightOfClubs, Cards.EightOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.SevenOfSpades, Cards.SevenOfHearts, Cards.SevenOfClubs, Cards.SevenOfDiamonds]
            }
        ]
    };

    public static Hand NinesOverTwos { get; } = new()
    {
        Name = "Nines Over Twos",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.NineOfSpades, Cards.NineOfHearts, Cards.NineOfClubs, Cards.NineOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.TwoOfSpades, Cards.TwoOfHearts, Cards.TwoOfClubs, Cards.TwoOfDiamonds]
            }
        ]
    };

    public static Hand NinesOverThrees { get; } = new()
    {
        Name = "Nines Over Threes",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.NineOfSpades, Cards.NineOfHearts, Cards.NineOfClubs, Cards.NineOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.ThreeOfSpades, Cards.ThreeOfHearts, Cards.ThreeOfClubs, Cards.ThreeOfDiamonds]
            }
        ]
    };

    public static Hand NinesOverFours { get; } = new()
    {
        Name = "Nines Over Fours",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.NineOfSpades, Cards.NineOfHearts, Cards.NineOfClubs, Cards.NineOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.FourOfSpades, Cards.FourOfHearts, Cards.FourOfClubs, Cards.FourOfDiamonds]
            }
        ]
    };

    public static Hand NinesOverFives { get; } = new()
    {
        Name = "Nines Over Fives",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.NineOfSpades, Cards.NineOfHearts, Cards.NineOfClubs, Cards.NineOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.FiveOfSpades, Cards.FiveOfHearts, Cards.FiveOfClubs, Cards.FiveOfDiamonds]
            }
        ]
    };

    public static Hand NinesOverSixes { get; } = new()
    {
        Name = "Nines Over Sixes",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.NineOfSpades, Cards.NineOfHearts, Cards.NineOfClubs, Cards.NineOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.SixOfSpades, Cards.SixOfHearts, Cards.SixOfClubs, Cards.SixOfDiamonds]
            }
        ]
    };

    public static Hand NinesOverSevens { get; } = new()
    {
        Name = "Nines Over Sevens",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.NineOfSpades, Cards.NineOfHearts, Cards.NineOfClubs, Cards.NineOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.SevenOfSpades, Cards.SevenOfHearts, Cards.SevenOfClubs, Cards.SevenOfDiamonds]
            }
        ]
    };

    public static Hand NinesOverEights { get; } = new()
    {
        Name = "Nines Over Eights",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.NineOfSpades, Cards.NineOfHearts, Cards.NineOfClubs, Cards.NineOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.EightOfSpades, Cards.EightOfHearts, Cards.EightOfClubs, Cards.EightOfDiamonds]
            }
        ]
    };

    public static Hand TensOverTwos { get; } = new()
    {
        Name = "Tens Over Twos",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.TenOfSpades, Cards.TenOfHearts, Cards.TenOfClubs, Cards.TenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.TwoOfSpades, Cards.TwoOfHearts, Cards.TwoOfClubs, Cards.TwoOfDiamonds]
            }
        ]
    };

    public static Hand TensOverThrees { get; } = new()
    {
        Name = "Tens Over Threes",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.TenOfSpades, Cards.TenOfHearts, Cards.TenOfClubs, Cards.TenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.ThreeOfSpades, Cards.ThreeOfHearts, Cards.ThreeOfClubs, Cards.ThreeOfDiamonds]
            }
        ]
    };

    public static Hand TensOverFours { get; } = new()
    {
        Name = "Tens Over Fours",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.TenOfSpades, Cards.TenOfHearts, Cards.TenOfClubs, Cards.TenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.FourOfSpades, Cards.FourOfHearts, Cards.FourOfClubs, Cards.FourOfDiamonds]
            }
        ]
    };

    public static Hand TensOverFives { get; } = new()
    {
        Name = "Tens Over Fives",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.TenOfSpades, Cards.TenOfHearts, Cards.TenOfClubs, Cards.TenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.FiveOfSpades, Cards.FiveOfHearts, Cards.FiveOfClubs, Cards.FiveOfDiamonds]
            }
        ]
    };

    public static Hand TensOverSixes { get; } = new()
    {
        Name = "Tens Over Sixes",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.TenOfSpades, Cards.TenOfHearts, Cards.TenOfClubs, Cards.TenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.SixOfSpades, Cards.SixOfHearts, Cards.SixOfClubs, Cards.SixOfDiamonds]
            }
        ]
    };

    public static Hand TensOverSevens { get; } = new()
    {
        Name = "Tens Over Sevens",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.TenOfSpades, Cards.TenOfHearts, Cards.TenOfClubs, Cards.TenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.SevenOfSpades, Cards.SevenOfHearts, Cards.SevenOfClubs, Cards.SevenOfDiamonds]
            }
        ]
    };

    public static Hand TensOverEights { get; } = new()
    {
        Name = "Tens Over Eights",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.TenOfSpades, Cards.TenOfHearts, Cards.TenOfClubs, Cards.TenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.EightOfSpades, Cards.EightOfHearts, Cards.EightOfClubs, Cards.EightOfDiamonds]
            }
        ]
    };

    public static Hand TensOverNines { get; } = new()
    {
        Name = "Tens Over Nines",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.TenOfSpades, Cards.TenOfHearts, Cards.TenOfClubs, Cards.TenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.NineOfSpades, Cards.NineOfHearts, Cards.NineOfClubs, Cards.NineOfDiamonds]
            }
        ]
    };

    public static Hand JacksOverTwos { get; } = new()
    {
        Name = "Jacks Over Twos",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.JackOfSpades, Cards.JackOfHearts, Cards.JackOfClubs, Cards.JackOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.TwoOfSpades, Cards.TwoOfHearts, Cards.TwoOfClubs, Cards.TwoOfDiamonds]
            }
        ]
    };

    public static Hand JacksOverThrees { get; } = new()
    {
        Name = "Jacks Over Threes",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.JackOfSpades, Cards.JackOfHearts, Cards.JackOfClubs, Cards.JackOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.ThreeOfSpades, Cards.ThreeOfHearts, Cards.ThreeOfClubs, Cards.ThreeOfDiamonds]
            }
        ]
    };

    public static Hand JacksOverFours { get; } = new()
    {
        Name = "Jacks Over Fours",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.JackOfSpades, Cards.JackOfHearts, Cards.JackOfClubs, Cards.JackOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.FourOfSpades, Cards.FourOfHearts, Cards.FourOfClubs, Cards.FourOfDiamonds]
            }
        ]
    };

    public static Hand JacksOverFives { get; } = new()
    {
        Name = "Jacks Over Fives",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.JackOfSpades, Cards.JackOfHearts, Cards.JackOfClubs, Cards.JackOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.FiveOfSpades, Cards.FiveOfHearts, Cards.FiveOfClubs, Cards.FiveOfDiamonds]
            }
        ]
    };

    public static Hand JacksOverSixes { get; } = new()
    {
        Name = "Jacks Over Sixes",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.JackOfSpades, Cards.JackOfHearts, Cards.JackOfClubs, Cards.JackOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.SixOfSpades, Cards.SixOfHearts, Cards.SixOfClubs, Cards.SixOfDiamonds]
            }
        ]
    };

    public static Hand JacksOverSevens { get; } = new()
    {
        Name = "Jacks Over Sevens",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.JackOfSpades, Cards.JackOfHearts, Cards.JackOfClubs, Cards.JackOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.SevenOfSpades, Cards.SevenOfHearts, Cards.SevenOfClubs, Cards.SevenOfDiamonds]
            }
        ]
    };

    public static Hand JacksOverEights { get; } = new()
    {
        Name = "Jacks Over Eights",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.JackOfSpades, Cards.JackOfHearts, Cards.JackOfClubs, Cards.JackOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.EightOfSpades, Cards.EightOfHearts, Cards.EightOfClubs, Cards.EightOfDiamonds]
            }
        ]
    };

    public static Hand JacksOverNines { get; } = new()
    {
        Name = "Jacks Over Nines",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.JackOfSpades, Cards.JackOfHearts, Cards.JackOfClubs, Cards.JackOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.NineOfSpades, Cards.NineOfHearts, Cards.NineOfClubs, Cards.NineOfDiamonds]
            }
        ]
    };

    public static Hand JacksOverTens { get; } = new()
    {
        Name = "Jacks Over Tens",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.JackOfSpades, Cards.JackOfHearts, Cards.JackOfClubs, Cards.JackOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.TenOfSpades, Cards.TenOfHearts, Cards.TenOfClubs, Cards.TenOfDiamonds]
            }
        ]
    };

    public static Hand QueensOverTwos { get; } = new()
    {
        Name = "Queens Over Twos",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.QueenOfSpades, Cards.QueenOfHearts, Cards.QueenOfClubs, Cards.QueenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.TwoOfSpades, Cards.TwoOfHearts, Cards.TwoOfClubs, Cards.TwoOfDiamonds]
            }
        ]
    };

    public static Hand QueensOverThrees { get; } = new()
    {
        Name = "Queens Over Threes",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.QueenOfSpades, Cards.QueenOfHearts, Cards.QueenOfClubs, Cards.QueenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.ThreeOfSpades, Cards.ThreeOfHearts, Cards.ThreeOfClubs, Cards.ThreeOfDiamonds]
            }
        ]
    };

    public static Hand QueensOverFours { get; } = new()
    {
        Name = "Queens Over Fours",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.QueenOfSpades, Cards.QueenOfHearts, Cards.QueenOfClubs, Cards.QueenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.FourOfSpades, Cards.FourOfHearts, Cards.FourOfClubs, Cards.FourOfDiamonds]
            }
        ]
    };

    public static Hand QueensOverFives { get; } = new()
    {
        Name = "Queens Over Fives",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.QueenOfSpades, Cards.QueenOfHearts, Cards.QueenOfClubs, Cards.QueenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.FiveOfSpades, Cards.FiveOfHearts, Cards.FiveOfClubs, Cards.FiveOfDiamonds]
            }
        ]
    };

    public static Hand QueensOverSixes { get; } = new()
    {
        Name = "Queens Over Sixes",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.QueenOfSpades, Cards.QueenOfHearts, Cards.QueenOfClubs, Cards.QueenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.SixOfSpades, Cards.SixOfHearts, Cards.SixOfClubs, Cards.SixOfDiamonds]
            }
        ]
    };

    public static Hand QueensOverSevens { get; } = new()
    {
        Name = "Queens Over Sevens",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.QueenOfSpades, Cards.QueenOfHearts, Cards.QueenOfClubs, Cards.QueenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.SevenOfSpades, Cards.SevenOfHearts, Cards.SevenOfClubs, Cards.SevenOfDiamonds]
            }
        ]
    };

    public static Hand QueensOverEights { get; } = new()
    {
        Name = "Queens Over Eights",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.QueenOfSpades, Cards.QueenOfHearts, Cards.QueenOfClubs, Cards.QueenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.EightOfSpades, Cards.EightOfHearts, Cards.EightOfClubs, Cards.EightOfDiamonds]
            }
        ]
    };

    public static Hand QueensOverNines { get; } = new()
    {
        Name = "Queens Over Nines",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.QueenOfSpades, Cards.QueenOfHearts, Cards.QueenOfClubs, Cards.QueenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.NineOfSpades, Cards.NineOfHearts, Cards.NineOfClubs, Cards.NineOfDiamonds]
            }
        ]
    };

    public static Hand QueensOverTens { get; } = new()
    {
        Name = "Queens Over Tens",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.QueenOfSpades, Cards.QueenOfHearts, Cards.QueenOfClubs, Cards.QueenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.TenOfSpades, Cards.TenOfHearts, Cards.TenOfClubs, Cards.TenOfDiamonds]
            }
        ]
    };

    public static Hand QueensOverJacks { get; } = new()
    {
        Name = "Queens Over Jacks",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.QueenOfSpades, Cards.QueenOfHearts, Cards.QueenOfClubs, Cards.QueenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.JackOfSpades, Cards.JackOfHearts, Cards.JackOfClubs, Cards.JackOfDiamonds]
            }
        ]
    };

    public static Hand KingsOverTwos { get; } = new()
    {
        Name = "Kings Over Twos",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.KingOfSpades, Cards.KingOfHearts, Cards.KingOfClubs, Cards.KingOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.TwoOfSpades, Cards.TwoOfHearts, Cards.TwoOfClubs, Cards.TwoOfDiamonds]
            }
        ]
    };

    public static Hand KingsOverThrees { get; } = new()
    {
        Name = "Kings Over Threes",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.KingOfSpades, Cards.KingOfHearts, Cards.KingOfClubs, Cards.KingOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.ThreeOfSpades, Cards.ThreeOfHearts, Cards.ThreeOfClubs, Cards.ThreeOfDiamonds]
            }
        ]
    };

    public static Hand KingsOverFours { get; } = new()
    {
        Name = "Kings Over Fours",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.KingOfSpades, Cards.KingOfHearts, Cards.KingOfClubs, Cards.KingOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.FourOfSpades, Cards.FourOfHearts, Cards.FourOfClubs, Cards.FourOfDiamonds]
            }
        ]
    };

    public static Hand KingsOverFives { get; } = new()
    {
        Name = "Kings Over Fives",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.KingOfSpades, Cards.KingOfHearts, Cards.KingOfClubs, Cards.KingOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.FiveOfSpades, Cards.FiveOfHearts, Cards.FiveOfClubs, Cards.FiveOfDiamonds]
            }
        ]
    };

    public static Hand KingsOverSixes { get; } = new()
    {
        Name = "Kings Over Sixes",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.KingOfSpades, Cards.KingOfHearts, Cards.KingOfClubs, Cards.KingOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.SixOfSpades, Cards.SixOfHearts, Cards.SixOfClubs, Cards.SixOfDiamonds]
            }
        ]
    };

    public static Hand KingsOverSevens { get; } = new()
    {
        Name = "Kings Over Sevens",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.KingOfSpades, Cards.KingOfHearts, Cards.KingOfClubs, Cards.KingOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.SevenOfSpades, Cards.SevenOfHearts, Cards.SevenOfClubs, Cards.SevenOfDiamonds]
            }
        ]
    };

    public static Hand KingsOverEights { get; } = new()
    {
        Name = "Kings Over Eights",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.KingOfSpades, Cards.KingOfHearts, Cards.KingOfClubs, Cards.KingOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.EightOfSpades, Cards.EightOfHearts, Cards.EightOfClubs, Cards.EightOfDiamonds]
            }
        ]
    };

    public static Hand KingsOverNines { get; } = new()
    {
        Name = "Kings Over Nines",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.KingOfSpades, Cards.KingOfHearts, Cards.KingOfClubs, Cards.KingOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.NineOfSpades, Cards.NineOfHearts, Cards.NineOfClubs, Cards.NineOfDiamonds]
            }
        ]
    };

    public static Hand KingsOverTens { get; } = new()
    {
        Name = "Kings Over Tens",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.KingOfSpades, Cards.KingOfHearts, Cards.KingOfClubs, Cards.KingOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.TenOfSpades, Cards.TenOfHearts, Cards.TenOfClubs, Cards.TenOfDiamonds]
            }
        ]
    };

    public static Hand KingsOverJacks { get; } = new()
    {
        Name = "Kings Over Jacks",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.KingOfSpades, Cards.KingOfHearts, Cards.KingOfClubs, Cards.KingOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.JackOfSpades, Cards.JackOfHearts, Cards.JackOfClubs, Cards.JackOfDiamonds]
            }
        ]
    };

    public static Hand KingsOverQueens { get; } = new()
    {
        Name = "Kings Over Queens",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.KingOfSpades, Cards.KingOfHearts, Cards.KingOfClubs, Cards.KingOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.QueenOfSpades, Cards.QueenOfHearts, Cards.QueenOfClubs, Cards.QueenOfDiamonds]
            }
        ]
    };

    public static Hand AcesOverTwos { get; } = new()
    {
        Name = "Aces Over Twos",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.AceOfSpades, Cards.AceOfHearts, Cards.AceOfClubs, Cards.AceOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.TwoOfSpades, Cards.TwoOfHearts, Cards.TwoOfClubs, Cards.TwoOfDiamonds]
            }
        ]
    };

    public static Hand AcesOverThrees { get; } = new()
    {
        Name = "Aces Over Threes",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.AceOfSpades, Cards.AceOfHearts, Cards.AceOfClubs, Cards.AceOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.ThreeOfSpades, Cards.ThreeOfHearts, Cards.ThreeOfClubs, Cards.ThreeOfDiamonds]
            }
        ]
    };

    public static Hand AcesOverFours { get; } = new()
    {
        Name = "Aces Over Fours",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.AceOfSpades, Cards.AceOfHearts, Cards.AceOfClubs, Cards.AceOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.FourOfSpades, Cards.FourOfHearts, Cards.FourOfClubs, Cards.FourOfDiamonds]
            }
        ]
    };

    public static Hand AcesOverFives { get; } = new()
    {
        Name = "Aces Over Fives",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.AceOfSpades, Cards.AceOfHearts, Cards.AceOfClubs, Cards.AceOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.FiveOfSpades, Cards.FiveOfHearts, Cards.FiveOfClubs, Cards.FiveOfDiamonds]
            }
        ]
    };

    public static Hand AcesOverSixes { get; } = new()
    {
        Name = "Aces Over Sixes",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.AceOfSpades, Cards.AceOfHearts, Cards.AceOfClubs, Cards.AceOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.SixOfSpades, Cards.SixOfHearts, Cards.SixOfClubs, Cards.SixOfDiamonds]
            }
        ]
    };

    public static Hand AcesOverSevens { get; } = new()
    {
        Name = "Aces Over Sevens",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.AceOfSpades, Cards.AceOfHearts, Cards.AceOfClubs, Cards.AceOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.SevenOfSpades, Cards.SevenOfHearts, Cards.SevenOfClubs, Cards.SevenOfDiamonds]
            }
        ]
    };

    public static Hand AcesOverEights { get; } = new()
    {
        Name = "Aces Over Eights",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.AceOfSpades, Cards.AceOfHearts, Cards.AceOfClubs, Cards.AceOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.EightOfSpades, Cards.EightOfHearts, Cards.EightOfClubs, Cards.EightOfDiamonds]
            }
        ]
    };

    public static Hand AcesOverNines { get; } = new()
    {
        Name = "Aces Over Nines",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.AceOfSpades, Cards.AceOfHearts, Cards.AceOfClubs, Cards.AceOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.NineOfSpades, Cards.NineOfHearts, Cards.NineOfClubs, Cards.NineOfDiamonds]
            }
        ]
    };

    public static Hand AcesOverTens { get; } = new()
    {
        Name = "Aces Over Tens",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.AceOfSpades, Cards.AceOfHearts, Cards.AceOfClubs, Cards.AceOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.TenOfSpades, Cards.TenOfHearts, Cards.TenOfClubs, Cards.TenOfDiamonds]
            }
        ]
    };

    public static Hand AcesOverJacks { get; } = new()
    {
        Name = "Aces Over Jacks",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.AceOfSpades, Cards.AceOfHearts, Cards.AceOfClubs, Cards.AceOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.JackOfSpades, Cards.JackOfHearts, Cards.JackOfClubs, Cards.JackOfDiamonds]
            }
        ]
    };

    public static Hand AcesOverQueens { get; } = new()
    {
        Name = "Aces Over Queens",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.AceOfSpades, Cards.AceOfHearts, Cards.AceOfClubs, Cards.AceOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.QueenOfSpades, Cards.QueenOfHearts, Cards.QueenOfClubs, Cards.QueenOfDiamonds]
            }
        ]
    };

    public static Hand AcesOverKings { get; } = new()
    {
        Name = "Aces Over Kings",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.AceOfSpades, Cards.AceOfHearts, Cards.AceOfClubs, Cards.AceOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.KingOfSpades, Cards.KingOfHearts, Cards.KingOfClubs, Cards.KingOfDiamonds]
            }
        ]
    };

}
