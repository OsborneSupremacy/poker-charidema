namespace Poker.Domain.Classic.Hands;

public static class Flushes
{
    public static Hand Spades { get; } = new()
    {
        Name = "Spades Flush",
        HandDefinition = HandDefinitions.Flush,
        HighRank = Ranks.Empty,
        Suit = Suits.Spades,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new() {
                    Cards.TwoOfSpades,
                    Cards.ThreeOfSpades,
                    Cards.FourOfSpades,
                    Cards.FiveOfSpades,
                    Cards.SixOfSpades,
                    Cards.SevenOfSpades,
                    Cards.EightOfSpades,
                    Cards.NineOfSpades,
                    Cards.TenOfSpades,
                    Cards.JackOfSpades,
                    Cards.QueenOfSpades,
                    Cards.KingOfSpades,
                    Cards.AceOfSpades
                }
            }
        }
    };

    public static Hand Hearts { get; } = new()
    {
        Name = "Hearts Flush",
        HandDefinition = HandDefinitions.Flush,
        HighRank = Ranks.Empty,
        Suit = Suits.Hearts,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.TwoOfHearts,
                    Cards.ThreeOfHearts,
                    Cards.FourOfHearts,
                    Cards.FiveOfHearts,
                    Cards.SixOfHearts,
                    Cards.SevenOfHearts,
                    Cards.EightOfHearts,
                    Cards.NineOfHearts,
                    Cards.TenOfHearts,
                    Cards.JackOfHearts,
                    Cards.QueenOfHearts,
                    Cards.KingOfHearts,
                    Cards.AceOfHearts                  
                }
            }
        }
    };

    public static Hand Diamonds { get; } = new()
    {
        Name = "Diamonds Flush",
        HandDefinition = HandDefinitions.Flush,
        HighRank = Ranks.Empty,
        Suit = Suits.Diamonds,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.TwoOfDiamonds,
                    Cards.ThreeOfDiamonds,
                    Cards.FourOfDiamonds,
                    Cards.FiveOfDiamonds,
                    Cards.SixOfDiamonds,
                    Cards.SevenOfDiamonds,
                    Cards.EightOfDiamonds,
                    Cards.NineOfDiamonds,
                    Cards.TenOfDiamonds,
                    Cards.JackOfDiamonds,
                    Cards.QueenOfDiamonds,
                    Cards.KingOfDiamonds,
                    Cards.AceOfDiamonds                  
                }
            }
        }
    };

    public static Hand Clubs { get; } = new()
    {
        Name = "Clubs Flush",
        HandDefinition = HandDefinitions.Flush,
        HighRank = Ranks.Empty,
        Suit = Suits.Clubs,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.TwoOfClubs,
                    Cards.ThreeOfClubs,
                    Cards.FourOfClubs,
                    Cards.FiveOfClubs,
                    Cards.SixOfClubs,
                    Cards.SevenOfClubs,
                    Cards.EightOfClubs,
                    Cards.NineOfClubs,
                    Cards.TenOfClubs,
                    Cards.JackOfClubs,
                    Cards.QueenOfClubs,
                    Cards.KingOfClubs,
                    Cards.AceOfClubs                  
                }
            }
        }
    };
}
