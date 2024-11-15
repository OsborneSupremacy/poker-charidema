﻿namespace Poker.Domain.Classic.Hands;

public static class FullHouses
{
    public static Hand TwosOverThrees { get; } = new()
    {
        Name = "Full House, Twos Over Threes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.TwoOfSpades, Cards.TwoOfHearts, Cards.TwoOfClubs, Cards.TwoOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.ThreeOfSpades, Cards.ThreeOfHearts, Cards.ThreeOfClubs, Cards.ThreeOfDiamonds]
            }
        ]
    };

    public static Hand TwosOverFours { get; } = new()
    {
        Name = "Full House, Twos Over Fours",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.TwoOfSpades, Cards.TwoOfHearts, Cards.TwoOfClubs, Cards.TwoOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.FourOfSpades, Cards.FourOfHearts, Cards.FourOfClubs, Cards.FourOfDiamonds]
            }
        ]
    };

    public static Hand TwosOverFives { get; } = new()
    {
        Name = "Full House, Twos Over Fives",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.TwoOfSpades, Cards.TwoOfHearts, Cards.TwoOfClubs, Cards.TwoOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.FiveOfSpades, Cards.FiveOfHearts, Cards.FiveOfClubs, Cards.FiveOfDiamonds]
            }
        ]
    };

    public static Hand TwosOverSixes { get; } = new()
    {
        Name = "Full House, Twos Over Sixes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.TwoOfSpades, Cards.TwoOfHearts, Cards.TwoOfClubs, Cards.TwoOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.SixOfSpades, Cards.SixOfHearts, Cards.SixOfClubs, Cards.SixOfDiamonds]
            }
        ]
    };

    public static Hand TwosOverSevens { get; } = new()
    {
        Name = "Full House, Twos Over Sevens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.TwoOfSpades, Cards.TwoOfHearts, Cards.TwoOfClubs, Cards.TwoOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.SevenOfSpades, Cards.SevenOfHearts, Cards.SevenOfClubs, Cards.SevenOfDiamonds]
            }
        ]
    };

    public static Hand TwosOverEights { get; } = new()
    {
        Name = "Full House, Twos Over Eights",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.TwoOfSpades, Cards.TwoOfHearts, Cards.TwoOfClubs, Cards.TwoOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.EightOfSpades, Cards.EightOfHearts, Cards.EightOfClubs, Cards.EightOfDiamonds]
            }
        ]
    };

    public static Hand TwosOverNines { get; } = new()
    {
        Name = "Full House, Twos Over Nines",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.TwoOfSpades, Cards.TwoOfHearts, Cards.TwoOfClubs, Cards.TwoOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.NineOfSpades, Cards.NineOfHearts, Cards.NineOfClubs, Cards.NineOfDiamonds]
            }
        ]
    };

    public static Hand TwosOverTens { get; } = new()
    {
        Name = "Full House, Twos Over Tens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.TwoOfSpades, Cards.TwoOfHearts, Cards.TwoOfClubs, Cards.TwoOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.TenOfSpades, Cards.TenOfHearts, Cards.TenOfClubs, Cards.TenOfDiamonds]
            }
        ]
    };

    public static Hand TwosOverJacks { get; } = new()
    {
        Name = "Full House, Twos Over Jacks",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.TwoOfSpades, Cards.TwoOfHearts, Cards.TwoOfClubs, Cards.TwoOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.JackOfSpades, Cards.JackOfHearts, Cards.JackOfClubs, Cards.JackOfDiamonds]
            }
        ]
    };

    public static Hand TwosOverQueens { get; } = new()
    {
        Name = "Full House, Twos Over Queens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.TwoOfSpades, Cards.TwoOfHearts, Cards.TwoOfClubs, Cards.TwoOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.QueenOfSpades, Cards.QueenOfHearts, Cards.QueenOfClubs, Cards.QueenOfDiamonds]
            }
        ]
    };

    public static Hand TwosOverKings { get; } = new()
    {
        Name = "Full House, Twos Over Kings",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.TwoOfSpades, Cards.TwoOfHearts, Cards.TwoOfClubs, Cards.TwoOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.KingOfSpades, Cards.KingOfHearts, Cards.KingOfClubs, Cards.KingOfDiamonds]
            }
        ]
    };

    public static Hand TwosOverAces { get; } = new()
    {
        Name = "Full House, Twos Over Aces",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.TwoOfSpades, Cards.TwoOfHearts, Cards.TwoOfClubs, Cards.TwoOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.AceOfSpades, Cards.AceOfHearts, Cards.AceOfClubs, Cards.AceOfDiamonds]
            }
        ]
    };

    public static Hand ThreesOverTwos { get; } = new()
    {
        Name = "Full House, Threes Over Twos",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Three,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.ThreeOfSpades, Cards.ThreeOfHearts, Cards.ThreeOfClubs, Cards.ThreeOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.TwoOfSpades, Cards.TwoOfHearts, Cards.TwoOfClubs, Cards.TwoOfDiamonds]
            }
        ]
    };

    public static Hand ThreesOverFours { get; } = new()
    {
        Name = "Full House, Threes Over Fours",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Three,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.ThreeOfSpades, Cards.ThreeOfHearts, Cards.ThreeOfClubs, Cards.ThreeOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.FourOfSpades, Cards.FourOfHearts, Cards.FourOfClubs, Cards.FourOfDiamonds]
            }
        ]
    };

    public static Hand ThreesOverFives { get; } = new()
    {
        Name = "Full House, Threes Over Fives",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Three,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.ThreeOfSpades, Cards.ThreeOfHearts, Cards.ThreeOfClubs, Cards.ThreeOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.FiveOfSpades, Cards.FiveOfHearts, Cards.FiveOfClubs, Cards.FiveOfDiamonds]
            }
        ]
    };

    public static Hand ThreesOverSixes { get; } = new()
    {
        Name = "Full House, Threes Over Sixes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Three,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.ThreeOfSpades, Cards.ThreeOfHearts, Cards.ThreeOfClubs, Cards.ThreeOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.SixOfSpades, Cards.SixOfHearts, Cards.SixOfClubs, Cards.SixOfDiamonds]
            }
        ]
    };

    public static Hand ThreesOverSevens { get; } = new()
    {
        Name = "Full House, Threes Over Sevens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Three,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.ThreeOfSpades, Cards.ThreeOfHearts, Cards.ThreeOfClubs, Cards.ThreeOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.SevenOfSpades, Cards.SevenOfHearts, Cards.SevenOfClubs, Cards.SevenOfDiamonds]
            }
        ]
    };

    public static Hand ThreesOverEights { get; } = new()
    {
        Name = "Full House, Threes Over Eights",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Three,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.ThreeOfSpades, Cards.ThreeOfHearts, Cards.ThreeOfClubs, Cards.ThreeOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.EightOfSpades, Cards.EightOfHearts, Cards.EightOfClubs, Cards.EightOfDiamonds]
            }
        ]
    };

    public static Hand ThreesOverNines { get; } = new()
    {
        Name = "Full House, Threes Over Nines",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Three,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.ThreeOfSpades, Cards.ThreeOfHearts, Cards.ThreeOfClubs, Cards.ThreeOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.NineOfSpades, Cards.NineOfHearts, Cards.NineOfClubs, Cards.NineOfDiamonds]
            }
        ]
    };

    public static Hand ThreesOverTens { get; } = new()
    {
        Name = "Full House, Threes Over Tens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Three,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.ThreeOfSpades, Cards.ThreeOfHearts, Cards.ThreeOfClubs, Cards.ThreeOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.TenOfSpades, Cards.TenOfHearts, Cards.TenOfClubs, Cards.TenOfDiamonds]
            }
        ]
    };

    public static Hand ThreesOverJacks { get; } = new()
    {
        Name = "Full House, Threes Over Jacks",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Three,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.ThreeOfSpades, Cards.ThreeOfHearts, Cards.ThreeOfClubs, Cards.ThreeOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.JackOfSpades, Cards.JackOfHearts, Cards.JackOfClubs, Cards.JackOfDiamonds]
            }
        ]
    };

    public static Hand ThreesOverQueens { get; } = new()
    {
        Name = "Full House, Threes Over Queens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Three,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.ThreeOfSpades, Cards.ThreeOfHearts, Cards.ThreeOfClubs, Cards.ThreeOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.QueenOfSpades, Cards.QueenOfHearts, Cards.QueenOfClubs, Cards.QueenOfDiamonds]
            }
        ]
    };

    public static Hand ThreesOverKings { get; } = new()
    {
        Name = "Full House, Threes Over Kings",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Three,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.ThreeOfSpades, Cards.ThreeOfHearts, Cards.ThreeOfClubs, Cards.ThreeOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.KingOfSpades, Cards.KingOfHearts, Cards.KingOfClubs, Cards.KingOfDiamonds]
            }
        ]
    };

    public static Hand ThreesOverAces { get; } = new()
    {
        Name = "Full House, Threes Over Aces",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Three,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.ThreeOfSpades, Cards.ThreeOfHearts, Cards.ThreeOfClubs, Cards.ThreeOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.AceOfSpades, Cards.AceOfHearts, Cards.AceOfClubs, Cards.AceOfDiamonds]
            }
        ]
    };

    public static Hand FoursOverTwos { get; } = new()
    {
        Name = "Full House, Fours Over Twos",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Four,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Fours Over Threes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Four,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.FourOfSpades, Cards.FourOfHearts, Cards.FourOfClubs, Cards.FourOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.ThreeOfSpades, Cards.ThreeOfHearts, Cards.ThreeOfClubs, Cards.ThreeOfDiamonds]
            }
        ]
    };

    public static Hand FoursOverFives { get; } = new()
    {
        Name = "Full House, Fours Over Fives",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Four,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.FourOfSpades, Cards.FourOfHearts, Cards.FourOfClubs, Cards.FourOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.FiveOfSpades, Cards.FiveOfHearts, Cards.FiveOfClubs, Cards.FiveOfDiamonds]
            }
        ]
    };

    public static Hand FoursOverSixes { get; } = new()
    {
        Name = "Full House, Fours Over Sixes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Four,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.FourOfSpades, Cards.FourOfHearts, Cards.FourOfClubs, Cards.FourOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.SixOfSpades, Cards.SixOfHearts, Cards.SixOfClubs, Cards.SixOfDiamonds]
            }
        ]
    };

    public static Hand FoursOverSevens { get; } = new()
    {
        Name = "Full House, Fours Over Sevens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Four,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.FourOfSpades, Cards.FourOfHearts, Cards.FourOfClubs, Cards.FourOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.SevenOfSpades, Cards.SevenOfHearts, Cards.SevenOfClubs, Cards.SevenOfDiamonds]
            }
        ]
    };

    public static Hand FoursOverEights { get; } = new()
    {
        Name = "Full House, Fours Over Eights",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Four,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.FourOfSpades, Cards.FourOfHearts, Cards.FourOfClubs, Cards.FourOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.EightOfSpades, Cards.EightOfHearts, Cards.EightOfClubs, Cards.EightOfDiamonds]
            }
        ]
    };

    public static Hand FoursOverNines { get; } = new()
    {
        Name = "Full House, Fours Over Nines",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Four,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.FourOfSpades, Cards.FourOfHearts, Cards.FourOfClubs, Cards.FourOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.NineOfSpades, Cards.NineOfHearts, Cards.NineOfClubs, Cards.NineOfDiamonds]
            }
        ]
    };

    public static Hand FoursOverTens { get; } = new()
    {
        Name = "Full House, Fours Over Tens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Four,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.FourOfSpades, Cards.FourOfHearts, Cards.FourOfClubs, Cards.FourOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.TenOfSpades, Cards.TenOfHearts, Cards.TenOfClubs, Cards.TenOfDiamonds]
            }
        ]
    };

    public static Hand FoursOverJacks { get; } = new()
    {
        Name = "Full House, Fours Over Jacks",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Four,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.FourOfSpades, Cards.FourOfHearts, Cards.FourOfClubs, Cards.FourOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.JackOfSpades, Cards.JackOfHearts, Cards.JackOfClubs, Cards.JackOfDiamonds]
            }
        ]
    };

    public static Hand FoursOverQueens { get; } = new()
    {
        Name = "Full House, Fours Over Queens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Four,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.FourOfSpades, Cards.FourOfHearts, Cards.FourOfClubs, Cards.FourOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.QueenOfSpades, Cards.QueenOfHearts, Cards.QueenOfClubs, Cards.QueenOfDiamonds]
            }
        ]
    };

    public static Hand FoursOverKings { get; } = new()
    {
        Name = "Full House, Fours Over Kings",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Four,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.FourOfSpades, Cards.FourOfHearts, Cards.FourOfClubs, Cards.FourOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.KingOfSpades, Cards.KingOfHearts, Cards.KingOfClubs, Cards.KingOfDiamonds]
            }
        ]
    };

    public static Hand FoursOverAces { get; } = new()
    {
        Name = "Full House, Fours Over Aces",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Four,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.FourOfSpades, Cards.FourOfHearts, Cards.FourOfClubs, Cards.FourOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.AceOfSpades, Cards.AceOfHearts, Cards.AceOfClubs, Cards.AceOfDiamonds]
            }
        ]
    };

    public static Hand FivesOverTwos { get; } = new()
    {
        Name = "Full House, Fives Over Twos",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Five,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Fives Over Threes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Five,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Fives Over Fours",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Five,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.FiveOfSpades, Cards.FiveOfHearts, Cards.FiveOfClubs, Cards.FiveOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.FourOfSpades, Cards.FourOfHearts, Cards.FourOfClubs, Cards.FourOfDiamonds]
            }
        ]
    };

    public static Hand FivesOverSixes { get; } = new()
    {
        Name = "Full House, Fives Over Sixes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Five,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.FiveOfSpades, Cards.FiveOfHearts, Cards.FiveOfClubs, Cards.FiveOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.SixOfSpades, Cards.SixOfHearts, Cards.SixOfClubs, Cards.SixOfDiamonds]
            }
        ]
    };

    public static Hand FivesOverSevens { get; } = new()
    {
        Name = "Full House, Fives Over Sevens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Five,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.FiveOfSpades, Cards.FiveOfHearts, Cards.FiveOfClubs, Cards.FiveOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.SevenOfSpades, Cards.SevenOfHearts, Cards.SevenOfClubs, Cards.SevenOfDiamonds]
            }
        ]
    };

    public static Hand FivesOverEights { get; } = new()
    {
        Name = "Full House, Fives Over Eights",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Five,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.FiveOfSpades, Cards.FiveOfHearts, Cards.FiveOfClubs, Cards.FiveOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.EightOfSpades, Cards.EightOfHearts, Cards.EightOfClubs, Cards.EightOfDiamonds]
            }
        ]
    };

    public static Hand FivesOverNines { get; } = new()
    {
        Name = "Full House, Fives Over Nines",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Five,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.FiveOfSpades, Cards.FiveOfHearts, Cards.FiveOfClubs, Cards.FiveOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.NineOfSpades, Cards.NineOfHearts, Cards.NineOfClubs, Cards.NineOfDiamonds]
            }
        ]
    };

    public static Hand FivesOverTens { get; } = new()
    {
        Name = "Full House, Fives Over Tens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Five,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.FiveOfSpades, Cards.FiveOfHearts, Cards.FiveOfClubs, Cards.FiveOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.TenOfSpades, Cards.TenOfHearts, Cards.TenOfClubs, Cards.TenOfDiamonds]
            }
        ]
    };

    public static Hand FivesOverJacks { get; } = new()
    {
        Name = "Full House, Fives Over Jacks",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Five,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.FiveOfSpades, Cards.FiveOfHearts, Cards.FiveOfClubs, Cards.FiveOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.JackOfSpades, Cards.JackOfHearts, Cards.JackOfClubs, Cards.JackOfDiamonds]
            }
        ]
    };

    public static Hand FivesOverQueens { get; } = new()
    {
        Name = "Full House, Fives Over Queens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Five,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.FiveOfSpades, Cards.FiveOfHearts, Cards.FiveOfClubs, Cards.FiveOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.QueenOfSpades, Cards.QueenOfHearts, Cards.QueenOfClubs, Cards.QueenOfDiamonds]
            }
        ]
    };

    public static Hand FivesOverKings { get; } = new()
    {
        Name = "Full House, Fives Over Kings",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Five,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.FiveOfSpades, Cards.FiveOfHearts, Cards.FiveOfClubs, Cards.FiveOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.KingOfSpades, Cards.KingOfHearts, Cards.KingOfClubs, Cards.KingOfDiamonds]
            }
        ]
    };

    public static Hand FivesOverAces { get; } = new()
    {
        Name = "Full House, Fives Over Aces",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Five,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.FiveOfSpades, Cards.FiveOfHearts, Cards.FiveOfClubs, Cards.FiveOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.AceOfSpades, Cards.AceOfHearts, Cards.AceOfClubs, Cards.AceOfDiamonds]
            }
        ]
    };

    public static Hand SixesOverTwos { get; } = new()
    {
        Name = "Full House, Sixes Over Twos",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Sixes Over Threes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Sixes Over Fours",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Sixes Over Fives",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.SixOfSpades, Cards.SixOfHearts, Cards.SixOfClubs, Cards.SixOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.FiveOfSpades, Cards.FiveOfHearts, Cards.FiveOfClubs, Cards.FiveOfDiamonds]
            }
        ]
    };

    public static Hand SixesOverSevens { get; } = new()
    {
        Name = "Full House, Sixes Over Sevens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.SixOfSpades, Cards.SixOfHearts, Cards.SixOfClubs, Cards.SixOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.SevenOfSpades, Cards.SevenOfHearts, Cards.SevenOfClubs, Cards.SevenOfDiamonds]
            }
        ]
    };

    public static Hand SixesOverEights { get; } = new()
    {
        Name = "Full House, Sixes Over Eights",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.SixOfSpades, Cards.SixOfHearts, Cards.SixOfClubs, Cards.SixOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.EightOfSpades, Cards.EightOfHearts, Cards.EightOfClubs, Cards.EightOfDiamonds]
            }
        ]
    };

    public static Hand SixesOverNines { get; } = new()
    {
        Name = "Full House, Sixes Over Nines",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.SixOfSpades, Cards.SixOfHearts, Cards.SixOfClubs, Cards.SixOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.NineOfSpades, Cards.NineOfHearts, Cards.NineOfClubs, Cards.NineOfDiamonds]
            }
        ]
    };

    public static Hand SixesOverTens { get; } = new()
    {
        Name = "Full House, Sixes Over Tens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.SixOfSpades, Cards.SixOfHearts, Cards.SixOfClubs, Cards.SixOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.TenOfSpades, Cards.TenOfHearts, Cards.TenOfClubs, Cards.TenOfDiamonds]
            }
        ]
    };

    public static Hand SixesOverJacks { get; } = new()
    {
        Name = "Full House, Sixes Over Jacks",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.SixOfSpades, Cards.SixOfHearts, Cards.SixOfClubs, Cards.SixOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.JackOfSpades, Cards.JackOfHearts, Cards.JackOfClubs, Cards.JackOfDiamonds]
            }
        ]
    };

    public static Hand SixesOverQueens { get; } = new()
    {
        Name = "Full House, Sixes Over Queens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.SixOfSpades, Cards.SixOfHearts, Cards.SixOfClubs, Cards.SixOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.QueenOfSpades, Cards.QueenOfHearts, Cards.QueenOfClubs, Cards.QueenOfDiamonds]
            }
        ]
    };

    public static Hand SixesOverKings { get; } = new()
    {
        Name = "Full House, Sixes Over Kings",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.SixOfSpades, Cards.SixOfHearts, Cards.SixOfClubs, Cards.SixOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.KingOfSpades, Cards.KingOfHearts, Cards.KingOfClubs, Cards.KingOfDiamonds]
            }
        ]
    };

    public static Hand SixesOverAces { get; } = new()
    {
        Name = "Full House, Sixes Over Aces",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.SixOfSpades, Cards.SixOfHearts, Cards.SixOfClubs, Cards.SixOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.AceOfSpades, Cards.AceOfHearts, Cards.AceOfClubs, Cards.AceOfDiamonds]
            }
        ]
    };

    public static Hand SevensOverTwos { get; } = new()
    {
        Name = "Full House, Sevens Over Twos",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Sevens Over Threes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Sevens Over Fours",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Sevens Over Fives",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Sevens Over Sixes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.SevenOfSpades, Cards.SevenOfHearts, Cards.SevenOfClubs, Cards.SevenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.SixOfSpades, Cards.SixOfHearts, Cards.SixOfClubs, Cards.SixOfDiamonds]
            }
        ]
    };

    public static Hand SevensOverEights { get; } = new()
    {
        Name = "Full House, Sevens Over Eights",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.SevenOfSpades, Cards.SevenOfHearts, Cards.SevenOfClubs, Cards.SevenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.EightOfSpades, Cards.EightOfHearts, Cards.EightOfClubs, Cards.EightOfDiamonds]
            }
        ]
    };

    public static Hand SevensOverNines { get; } = new()
    {
        Name = "Full House, Sevens Over Nines",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.SevenOfSpades, Cards.SevenOfHearts, Cards.SevenOfClubs, Cards.SevenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.NineOfSpades, Cards.NineOfHearts, Cards.NineOfClubs, Cards.NineOfDiamonds]
            }
        ]
    };

    public static Hand SevensOverTens { get; } = new()
    {
        Name = "Full House, Sevens Over Tens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.SevenOfSpades, Cards.SevenOfHearts, Cards.SevenOfClubs, Cards.SevenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.TenOfSpades, Cards.TenOfHearts, Cards.TenOfClubs, Cards.TenOfDiamonds]
            }
        ]
    };

    public static Hand SevensOverJacks { get; } = new()
    {
        Name = "Full House, Sevens Over Jacks",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.SevenOfSpades, Cards.SevenOfHearts, Cards.SevenOfClubs, Cards.SevenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.JackOfSpades, Cards.JackOfHearts, Cards.JackOfClubs, Cards.JackOfDiamonds]
            }
        ]
    };

    public static Hand SevensOverQueens { get; } = new()
    {
        Name = "Full House, Sevens Over Queens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.SevenOfSpades, Cards.SevenOfHearts, Cards.SevenOfClubs, Cards.SevenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.QueenOfSpades, Cards.QueenOfHearts, Cards.QueenOfClubs, Cards.QueenOfDiamonds]
            }
        ]
    };

    public static Hand SevensOverKings { get; } = new()
    {
        Name = "Full House, Sevens Over Kings",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.SevenOfSpades, Cards.SevenOfHearts, Cards.SevenOfClubs, Cards.SevenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.KingOfSpades, Cards.KingOfHearts, Cards.KingOfClubs, Cards.KingOfDiamonds]
            }
        ]
    };

    public static Hand SevensOverAces { get; } = new()
    {
        Name = "Full House, Sevens Over Aces",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.SevenOfSpades, Cards.SevenOfHearts, Cards.SevenOfClubs, Cards.SevenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.AceOfSpades, Cards.AceOfHearts, Cards.AceOfClubs, Cards.AceOfDiamonds]
            }
        ]
    };

    public static Hand EightsOverTwos { get; } = new()
    {
        Name = "Full House, Eights Over Twos",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Eights Over Threes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Eights Over Fours",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Eights Over Fives",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Eights Over Sixes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Eights Over Sevens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.EightOfSpades, Cards.EightOfHearts, Cards.EightOfClubs, Cards.EightOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.SevenOfSpades, Cards.SevenOfHearts, Cards.SevenOfClubs, Cards.SevenOfDiamonds]
            }
        ]
    };

    public static Hand EightsOverNines { get; } = new()
    {
        Name = "Full House, Eights Over Nines",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.EightOfSpades, Cards.EightOfHearts, Cards.EightOfClubs, Cards.EightOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.NineOfSpades, Cards.NineOfHearts, Cards.NineOfClubs, Cards.NineOfDiamonds]
            }
        ]
    };

    public static Hand EightsOverTens { get; } = new()
    {
        Name = "Full House, Eights Over Tens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.EightOfSpades, Cards.EightOfHearts, Cards.EightOfClubs, Cards.EightOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.TenOfSpades, Cards.TenOfHearts, Cards.TenOfClubs, Cards.TenOfDiamonds]
            }
        ]
    };

    public static Hand EightsOverJacks { get; } = new()
    {
        Name = "Full House, Eights Over Jacks",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.EightOfSpades, Cards.EightOfHearts, Cards.EightOfClubs, Cards.EightOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.JackOfSpades, Cards.JackOfHearts, Cards.JackOfClubs, Cards.JackOfDiamonds]
            }
        ]
    };

    public static Hand EightsOverQueens { get; } = new()
    {
        Name = "Full House, Eights Over Queens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.EightOfSpades, Cards.EightOfHearts, Cards.EightOfClubs, Cards.EightOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.QueenOfSpades, Cards.QueenOfHearts, Cards.QueenOfClubs, Cards.QueenOfDiamonds]
            }
        ]
    };

    public static Hand EightsOverKings { get; } = new()
    {
        Name = "Full House, Eights Over Kings",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.EightOfSpades, Cards.EightOfHearts, Cards.EightOfClubs, Cards.EightOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.KingOfSpades, Cards.KingOfHearts, Cards.KingOfClubs, Cards.KingOfDiamonds]
            }
        ]
    };

    public static Hand EightsOverAces { get; } = new()
    {
        Name = "Full House, Eights Over Aces",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.EightOfSpades, Cards.EightOfHearts, Cards.EightOfClubs, Cards.EightOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.AceOfSpades, Cards.AceOfHearts, Cards.AceOfClubs, Cards.AceOfDiamonds]
            }
        ]
    };

    public static Hand NinesOverTwos { get; } = new()
    {
        Name = "Full House, Nines Over Twos",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Nines Over Threes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Nines Over Fours",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Nines Over Fives",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Nines Over Sixes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Nines Over Sevens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Nines Over Eights",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.NineOfSpades, Cards.NineOfHearts, Cards.NineOfClubs, Cards.NineOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.EightOfSpades, Cards.EightOfHearts, Cards.EightOfClubs, Cards.EightOfDiamonds]
            }
        ]
    };

    public static Hand NinesOverTens { get; } = new()
    {
        Name = "Full House, Nines Over Tens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.NineOfSpades, Cards.NineOfHearts, Cards.NineOfClubs, Cards.NineOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.TenOfSpades, Cards.TenOfHearts, Cards.TenOfClubs, Cards.TenOfDiamonds]
            }
        ]
    };

    public static Hand NinesOverJacks { get; } = new()
    {
        Name = "Full House, Nines Over Jacks",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.NineOfSpades, Cards.NineOfHearts, Cards.NineOfClubs, Cards.NineOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.JackOfSpades, Cards.JackOfHearts, Cards.JackOfClubs, Cards.JackOfDiamonds]
            }
        ]
    };

    public static Hand NinesOverQueens { get; } = new()
    {
        Name = "Full House, Nines Over Queens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.NineOfSpades, Cards.NineOfHearts, Cards.NineOfClubs, Cards.NineOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.QueenOfSpades, Cards.QueenOfHearts, Cards.QueenOfClubs, Cards.QueenOfDiamonds]
            }
        ]
    };

    public static Hand NinesOverKings { get; } = new()
    {
        Name = "Full House, Nines Over Kings",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.NineOfSpades, Cards.NineOfHearts, Cards.NineOfClubs, Cards.NineOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.KingOfSpades, Cards.KingOfHearts, Cards.KingOfClubs, Cards.KingOfDiamonds]
            }
        ]
    };

    public static Hand NinesOverAces { get; } = new()
    {
        Name = "Full House, Nines Over Aces",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.NineOfSpades, Cards.NineOfHearts, Cards.NineOfClubs, Cards.NineOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.AceOfSpades, Cards.AceOfHearts, Cards.AceOfClubs, Cards.AceOfDiamonds]
            }
        ]
    };

    public static Hand TensOverTwos { get; } = new()
    {
        Name = "Full House, Tens Over Twos",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Tens Over Threes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Tens Over Fours",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Tens Over Fives",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Tens Over Sixes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Tens Over Sevens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Tens Over Eights",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Tens Over Nines",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.TenOfSpades, Cards.TenOfHearts, Cards.TenOfClubs, Cards.TenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.NineOfSpades, Cards.NineOfHearts, Cards.NineOfClubs, Cards.NineOfDiamonds]
            }
        ]
    };

    public static Hand TensOverJacks { get; } = new()
    {
        Name = "Full House, Tens Over Jacks",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.TenOfSpades, Cards.TenOfHearts, Cards.TenOfClubs, Cards.TenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.JackOfSpades, Cards.JackOfHearts, Cards.JackOfClubs, Cards.JackOfDiamonds]
            }
        ]
    };

    public static Hand TensOverQueens { get; } = new()
    {
        Name = "Full House, Tens Over Queens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.TenOfSpades, Cards.TenOfHearts, Cards.TenOfClubs, Cards.TenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.QueenOfSpades, Cards.QueenOfHearts, Cards.QueenOfClubs, Cards.QueenOfDiamonds]
            }
        ]
    };

    public static Hand TensOverKings { get; } = new()
    {
        Name = "Full House, Tens Over Kings",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.TenOfSpades, Cards.TenOfHearts, Cards.TenOfClubs, Cards.TenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.KingOfSpades, Cards.KingOfHearts, Cards.KingOfClubs, Cards.KingOfDiamonds]
            }
        ]
    };

    public static Hand TensOverAces { get; } = new()
    {
        Name = "Full House, Tens Over Aces",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.TenOfSpades, Cards.TenOfHearts, Cards.TenOfClubs, Cards.TenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.AceOfSpades, Cards.AceOfHearts, Cards.AceOfClubs, Cards.AceOfDiamonds]
            }
        ]
    };

    public static Hand JacksOverTwos { get; } = new()
    {
        Name = "Full House, Jacks Over Twos",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Jacks Over Threes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Jacks Over Fours",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Jacks Over Fives",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Jacks Over Sixes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Jacks Over Sevens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Jacks Over Eights",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Jacks Over Nines",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Jacks Over Tens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.JackOfSpades, Cards.JackOfHearts, Cards.JackOfClubs, Cards.JackOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.TenOfSpades, Cards.TenOfHearts, Cards.TenOfClubs, Cards.TenOfDiamonds]
            }
        ]
    };

    public static Hand JacksOverQueens { get; } = new()
    {
        Name = "Full House, Jacks Over Queens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.JackOfSpades, Cards.JackOfHearts, Cards.JackOfClubs, Cards.JackOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.QueenOfSpades, Cards.QueenOfHearts, Cards.QueenOfClubs, Cards.QueenOfDiamonds]
            }
        ]
    };

    public static Hand JacksOverKings { get; } = new()
    {
        Name = "Full House, Jacks Over Kings",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.JackOfSpades, Cards.JackOfHearts, Cards.JackOfClubs, Cards.JackOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.KingOfSpades, Cards.KingOfHearts, Cards.KingOfClubs, Cards.KingOfDiamonds]
            }
        ]
    };

    public static Hand JacksOverAces { get; } = new()
    {
        Name = "Full House, Jacks Over Aces",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.JackOfSpades, Cards.JackOfHearts, Cards.JackOfClubs, Cards.JackOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.AceOfSpades, Cards.AceOfHearts, Cards.AceOfClubs, Cards.AceOfDiamonds]
            }
        ]
    };

    public static Hand QueensOverTwos { get; } = new()
    {
        Name = "Full House, Queens Over Twos",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Queens Over Threes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Queens Over Fours",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Queens Over Fives",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Queens Over Sixes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Queens Over Sevens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Queens Over Eights",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Queens Over Nines",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Queens Over Tens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Queens Over Jacks",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.QueenOfSpades, Cards.QueenOfHearts, Cards.QueenOfClubs, Cards.QueenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.JackOfSpades, Cards.JackOfHearts, Cards.JackOfClubs, Cards.JackOfDiamonds]
            }
        ]
    };

    public static Hand QueensOverKings { get; } = new()
    {
        Name = "Full House, Queens Over Kings",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.QueenOfSpades, Cards.QueenOfHearts, Cards.QueenOfClubs, Cards.QueenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.KingOfSpades, Cards.KingOfHearts, Cards.KingOfClubs, Cards.KingOfDiamonds]
            }
        ]
    };

    public static Hand QueensOverAces { get; } = new()
    {
        Name = "Full House, Queens Over Aces",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.QueenOfSpades, Cards.QueenOfHearts, Cards.QueenOfClubs, Cards.QueenOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.AceOfSpades, Cards.AceOfHearts, Cards.AceOfClubs, Cards.AceOfDiamonds]
            }
        ]
    };

    public static Hand KingsOverTwos { get; } = new()
    {
        Name = "Full House, Kings Over Twos",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Kings Over Threes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Kings Over Fours",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Kings Over Fives",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Kings Over Sixes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Kings Over Sevens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Kings Over Eights",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Kings Over Nines",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Kings Over Tens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Kings Over Jacks",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Kings Over Queens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.KingOfSpades, Cards.KingOfHearts, Cards.KingOfClubs, Cards.KingOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.QueenOfSpades, Cards.QueenOfHearts, Cards.QueenOfClubs, Cards.QueenOfDiamonds]
            }
        ]
    };

    public static Hand KingsOverAces { get; } = new()
    {
        Name = "Full House, Kings Over Aces",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
                EligibleCards = [Cards.KingOfSpades, Cards.KingOfHearts, Cards.KingOfClubs, Cards.KingOfDiamonds]
            },

            new()
            {
                RequiredCount = 2,
                EligibleCards = [Cards.AceOfSpades, Cards.AceOfHearts, Cards.AceOfClubs, Cards.AceOfDiamonds]
            }
        ]
    };

    public static Hand AcesOverTwos { get; } = new()
    {
        Name = "Full House, Aces Over Twos",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Aces Over Threes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Aces Over Fours",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Aces Over Fives",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Aces Over Sixes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Aces Over Sevens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Aces Over Eights",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Aces Over Nines",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Aces Over Tens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Aces Over Jacks",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Aces Over Queens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
        Name = "Full House, Aces Over Kings",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 3,
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
