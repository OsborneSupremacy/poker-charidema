namespace Poker.Domain.Classic;

public static class Cards
{
    public static Card Empty { get; } = new()
    {
        Value = string.Empty,
        CardType = CardTypes.Empty,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Empty,
        Suit = Suits.Empty,
        Holdings = new()
    };

    public static Card TwoOfHearts { get; } = new()
    {
        Value = "2H",
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Two,
        Suit = Suits.Hearts,
        Holdings = new()
    };

    public static Card ThreeOfHearts { get; } = new()
    {
        Value = "3H",
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Three,
        Suit = Suits.Hearts,
        Holdings = new()
    };

    public static Card FourOfHearts { get; } = new()
    {
        Value = "4H",
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Four,
        Suit = Suits.Hearts,
        Holdings = new()
    };

    public static Card FiveOfHearts { get; } = new()
    {
        Value = "5H",
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Five,
        Suit = Suits.Hearts,
        Holdings = new()
    };

    public static Card SixOfHearts { get; } = new()
    {
        Value = "6H",
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Six,
        Suit = Suits.Hearts,
        Holdings = new()
    };

    public static Card SevenOfHearts { get; } = new()
    {
        Value = "7H",
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Seven,
        Suit = Suits.Hearts,
        Holdings = new()
    };

    public static Card EightOfHearts { get; } = new()
    {
        Value = "8H",
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Eight,
        Suit = Suits.Hearts,
        Holdings = new()
    };

    public static Card NineOfHearts { get; } = new()
    {
        Value = "9H",
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Nine,
        Suit = Suits.Hearts,
        Holdings = new()
    };

    public static Card TenOfHearts { get; } = new()
    {
        Value = "10H",
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Ten,
        Suit = Suits.Hearts,
        Holdings = new()
    };

    public static Card JackOfHearts { get; } = new()
    {
        Value = "JH",
        CardType = CardTypes.Face,
        IsWild = false,
        Rank = Ranks.Jack,
        Suit = Suits.Hearts,
        FaceDirection = FaceDirections.Left,
        Holdings = new()
            {
                Holding.Flower
            }
    };

    public static Card QueenOfHearts { get; } = new()
    {
        Value = "QH",
        CardType = CardTypes.Face,
        IsWild = false,
        Rank = Ranks.Queen,
        Suit = Suits.Hearts,
        FaceDirection = FaceDirections.Left,
        Holdings = new()
            {
                Holding.Flower
            }
    };

    public static Card KingOfHearts { get; } = new()
    {
        Value = "KH",
        CardType = CardTypes.Face,
        IsWild = false,
        Rank = Ranks.King,
        Suit = Suits.Hearts,
        FaceDirection = FaceDirections.Left,
        Holdings = new()
            {
                Holding.Sword
            }
    };

    public static Card AceOfHearts { get; } = new()
    {
        Value = "AH",
        IsWild = false,
        CardType = CardTypes.Ace,
        FaceDirection = FaceDirections.NotApplicable,
        Rank = Ranks.Ace,
        Suit = Suits.Hearts,
        Holdings = new()
    };

    public static Card TwoOfDiamonds { get; } = new()
    {
        Value = "2D",
        IsWild = false,
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        Rank = Ranks.Two,
        Suit = Suits.Diamonds,
        Holdings = new()
    };

    public static Card ThreeOfDiamonds { get; } = new()
    {
        Value = "3D",
        IsWild = false,
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        Rank = Ranks.Three,
        Suit = Suits.Diamonds,
        Holdings = new()
    };

    public static Card FourOfDiamonds { get; } = new()
    {
        Value = "4D",
        IsWild = false,
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        Rank = Ranks.Four,
        Suit = Suits.Diamonds,
        Holdings = new()
    };

    public static Card FiveOfDiamonds { get; } = new()
    {
        Value = "5D",
        IsWild = false,
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        Rank = Ranks.Five,
        Suit = Suits.Diamonds,
        Holdings = new()
    };

    public static Card SixOfDiamonds { get; } = new()
    {
        Value = "6D",
        IsWild = false,
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        Rank = Ranks.Six,
        Suit = Suits.Diamonds,
        Holdings = new()
    };

    public static Card SevenOfDiamonds { get; } = new()
    {
        Value = "7D",
        IsWild = false,
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        Rank = Ranks.Seven,
        Suit = Suits.Diamonds,
        Holdings = new()
    };

    public static Card EightOfDiamonds { get; } = new()
    {
        Value = "8D",
        IsWild = false,
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        Rank = Ranks.Eight,
        Suit = Suits.Diamonds,
        Holdings = new()
    };

    public static Card NineOfDiamonds { get; } = new()
    {
        Value = "9D",
        IsWild = false,
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        Rank = Ranks.Nine,
        Suit = Suits.Diamonds,
        Holdings = new()
    };

    public static Card TenOfDiamonds { get; } = new()
    {
        Value = "10D",
        IsWild = false,
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        Rank = Ranks.Ten,
        Suit = Suits.Diamonds,
        Holdings = new()
    };

    public static Card JackOfDiamonds { get; } = new()
    {
        Value = "JD",
        IsWild = false,
        CardType = CardTypes.Face,
        Rank = Ranks.Jack,
        Suit = Suits.Diamonds,
        FaceDirection = FaceDirections.Left,
        Holdings = new()
            {
                Holding.Flower
            }
    };

    public static Card QueenOfDiamonds { get; } = new()
    {
        Value = "QD",
        IsWild = false,
        CardType = CardTypes.Face,
        Rank = Ranks.Queen,
        Suit = Suits.Diamonds,
        FaceDirection = FaceDirections.Left,
        Holdings = new()
            {
                Holding.Flower
            }
    };

    public static Card KingOfDiamonds { get; } = new()
    {
        Value = "KD",
        IsWild = false,
        CardType = CardTypes.Face,
        Rank = Ranks.King,
        Suit = Suits.Diamonds,
        FaceDirection = FaceDirections.Left,
        Holdings = new()
            {
                Holding.Sword
            }
    };

    public static Card AceOfDiamonds { get; } = new()
    {
        Value = "AD",
        CardType = CardTypes.Ace,
        IsWild = false,
        Rank = Ranks.Ace,
        Suit = Suits.Diamonds,
        FaceDirection = FaceDirections.NotApplicable,
        Holdings = new()
    };

    public static Card TwoOfClubs { get; } = new()
    {
        Value = "2C",
        IsWild = false,
        Rank = Ranks.Two,
        Suit = Suits.Clubs,
        FaceDirection = FaceDirections.NotApplicable,
        Holdings = new(),
        CardType = CardTypes.Spot
    };

    public static Card ThreeOfClubs { get; } = new()
    {
        Value = "3C",
        IsWild = false,
        Rank = Ranks.Three,
        Suit = Suits.Clubs,
        FaceDirection = FaceDirections.NotApplicable,
        Holdings = new(),
        CardType = CardTypes.Spot
    };

    public static Card FourOfClubs { get; } = new()
    {
        Value = "4C",
        IsWild = false,
        Rank = Ranks.Four,
        Suit = Suits.Clubs,
        FaceDirection = FaceDirections.NotApplicable,
        Holdings = new(),
        CardType = CardTypes.Spot
    };

    public static Card FiveOfClubs { get; } = new()
    {
        Value = "5C",
        IsWild = false,
        Rank = Ranks.Five,
        Suit = Suits.Clubs,
        FaceDirection = FaceDirections.NotApplicable,
        Holdings = new(),
        CardType = CardTypes.Spot
    };

    public static Card SixOfClubs { get; } = new()
    {
        Value = "6C",
        IsWild = false,
        Rank = Ranks.Six,
        Suit = Suits.Clubs,
        FaceDirection = FaceDirections.NotApplicable,
        Holdings = new(),
        CardType = CardTypes.Spot
    };

    public static Card SevenOfClubs { get; } = new()
    {
        Value = "7C",
        IsWild = false,
        Rank = Ranks.Seven,
        Suit = Suits.Clubs,
        FaceDirection = FaceDirections.NotApplicable,
        Holdings = new(),
        CardType = CardTypes.Spot
    };

    public static Card EightOfClubs { get; } = new()
    {
        Value = "8C",
        IsWild = false,
        Rank = Ranks.Eight,
        Suit = Suits.Clubs,
        FaceDirection = FaceDirections.NotApplicable,
        Holdings = new(),
        CardType = CardTypes.Spot
    };

    public static Card NineOfClubs { get; } = new()
    {
        Value = "9C",
        IsWild = false,
        Rank = Ranks.Nine,
        Suit = Suits.Clubs,
        FaceDirection = FaceDirections.NotApplicable,
        Holdings = new(),
        CardType = CardTypes.Spot
    };

    public static Card TenOfClubs { get; } = new()
    {
        Value = "10C",
        IsWild = false,
        Rank = Ranks.Ten,
        Suit = Suits.Clubs,
        FaceDirection = FaceDirections.NotApplicable,
        Holdings = new(),
        CardType = CardTypes.Spot
    };

    public static Card JackOfClubs { get; } = new()
    {
        Value = "JC",
        IsWild = false,
        CardType = CardTypes.Face,
        Rank = Ranks.Jack,
        Suit = Suits.Clubs,
        FaceDirection = FaceDirections.Right,
        Holdings = new()
            {
                Holding.Flower
            }
    };

    public static Card QueenOfClubs { get; } = new()
    {
        Value = "QC",
        IsWild = false,
        CardType = CardTypes.Face,
        Rank = Ranks.Queen,
        Suit = Suits.Clubs,
        FaceDirection = FaceDirections.Left,
        Holdings = new()
            {
                Holding.Flower
            }
    };

    public static Card KingOfClubs { get; } = new()
    {
        Value = "KC",
        IsWild = false,
        CardType = CardTypes.Face,
        Rank = Ranks.King,
        Suit = Suits.Clubs,
        FaceDirection = FaceDirections.Left,
        Holdings = new()
            {
                Holding.Sword
            }
    };

    public static Card AceOfClubs { get; } = new()
    {
        Value = "AC",
        IsWild = false,
        CardType = CardTypes.Ace,
        Rank = Ranks.Ace,
        Suit = Suits.Clubs,
        FaceDirection = FaceDirections.NotApplicable,
        Holdings = new()
    };

    public static Card TwoOfSpades { get; } = new()
    {
        Value = "2S",
        IsWild = false,
        Rank = Ranks.Two,
        Suit = Suits.Spades,
        FaceDirection = FaceDirections.NotApplicable,
        CardType = CardTypes.Spot,
        Holdings = new()
    };

    public static Card ThreeOfSpades { get; } = new()
    {
        Value = "3S",
        IsWild = false,
        Rank = Ranks.Three,
        Suit = Suits.Spades,
        FaceDirection = FaceDirections.NotApplicable,
        CardType = CardTypes.Spot,
        Holdings = new()
    };

    public static Card FourOfSpades { get; } = new()
    {
        Value = "4S",
        IsWild = false,
        Rank = Ranks.Four,
        Suit = Suits.Spades,
        FaceDirection = FaceDirections.NotApplicable,
        CardType = CardTypes.Spot,
        Holdings = new()
    };

    public static Card FiveOfSpades { get; } = new()
    {
        Value = "5S",
        IsWild = false,
        Rank = Ranks.Five,
        Suit = Suits.Spades,
        FaceDirection = FaceDirections.NotApplicable,
        CardType = CardTypes.Spot,
        Holdings = new()
    };

    public static Card SixOfSpades { get; } = new()
    {
        Value = "6S",
        IsWild = false,
        Rank = Ranks.Six,
        Suit = Suits.Spades,
        FaceDirection = FaceDirections.NotApplicable,
        CardType = CardTypes.Spot,
        Holdings = new()
    };

    public static Card SevenOfSpades { get; } = new()
    {
        Value = "7S",
        IsWild = false,
        Rank = Ranks.Seven,
        Suit = Suits.Spades,
        FaceDirection = FaceDirections.NotApplicable,
        CardType = CardTypes.Spot,
        Holdings = new()
    };

    public static Card EightOfSpades { get; } = new()
    {
        Value = "8S",
        IsWild = false,
        Rank = Ranks.Eight,
        Suit = Suits.Spades,
        FaceDirection = FaceDirections.NotApplicable,
        CardType = CardTypes.Spot,
        Holdings = new()
    };

    public static Card NineOfSpades { get; } = new()
    {
        Value = "9S",
        IsWild = false,
        Rank = Ranks.Nine,
        Suit = Suits.Spades,
        FaceDirection = FaceDirections.NotApplicable,
        CardType = CardTypes.Spot,
        Holdings = new()
    };

    public static Card TenOfSpades { get; } = new()
    {
        Value = "10S",
        IsWild = false,
        Rank = Ranks.Ten,
        Suit = Suits.Spades,
        FaceDirection = FaceDirections.NotApplicable,
        CardType = CardTypes.Spot,
        Holdings = new()
    };

    public static Card JackOfSpades { get; } = new()
    {
        Value = "JS",
        IsWild = false,
        CardType = CardTypes.Face,
        Rank = Ranks.Jack,
        Suit = Suits.Spades,
        FaceDirection = FaceDirections.Right,
        Holdings = new()
            {
                Holding.Scepter
            }
    };

    public static Card QueenOfSpades { get; } = new()
    {
        Value = "QS",
        IsWild = false,
        CardType = CardTypes.Face,
        Rank = Ranks.Queen,
        Suit = Suits.Spades,
        FaceDirection = FaceDirections.Right,
        Holdings = new()
            {
                Holding.Flower
            }
    };

    public static Card KingOfSpades { get; } = new()
    {
        Value = "KS",
        IsWild = false,
        CardType = CardTypes.Face,
        Rank = Ranks.King,
        Suit = Suits.Spades,
        FaceDirection = FaceDirections.Right,
        Holdings = new()
            {
                Holding.Sword
            }
    };

    public static Card AceOfSpades { get; } = new()
    {
        Value = "AS",
        IsWild = false,
        CardType = CardTypes.Ace,
        Rank = Ranks.Ace,
        Suit = Suits.Spades,
        FaceDirection = FaceDirections.NotApplicable,
        Holdings = new()
    };

    public static Card CreateJoker() => new()
    {
        Value = "J",
        IsWild = true,
        CardType = CardTypes.Joker,
        Rank = Ranks.Empty,
        Suit = Suits.Empty,
        FaceDirection = FaceDirections.NotApplicable,
        Holdings = new()
    };

    public static List<Card> All { get; } = new() {
        // hearts
        TwoOfHearts,
        ThreeOfHearts,
        FourOfHearts,
        FiveOfHearts,
        SixOfHearts,
        SevenOfHearts,
        EightOfHearts,
        NineOfHearts,
        TenOfHearts,
        JackOfHearts,
        QueenOfHearts,
        KingOfHearts,
        AceOfHearts,
        
        // diamonds
        TwoOfDiamonds,
        ThreeOfDiamonds,
        FourOfDiamonds,
        FiveOfDiamonds,
        SixOfDiamonds,
        SevenOfDiamonds,
        EightOfDiamonds,
        NineOfDiamonds,
        TenOfDiamonds,
        JackOfDiamonds,
        QueenOfDiamonds,
        KingOfDiamonds,
        AceOfDiamonds,
        
        // clubs
        TwoOfClubs,
        ThreeOfClubs,
        FourOfClubs,
        FiveOfClubs,
        SixOfClubs,
        SevenOfClubs,
        EightOfClubs,
        NineOfClubs,
        TenOfClubs,
        JackOfClubs,
        QueenOfClubs,
        KingOfClubs,
        AceOfClubs,
        
        // spades
        TwoOfSpades,
        ThreeOfSpades,
        FourOfSpades,
        FiveOfSpades,
        SixOfSpades,
        SevenOfSpades,
        EightOfSpades,
        NineOfSpades,
        TenOfSpades,
        JackOfSpades,
        QueenOfSpades,
        KingOfSpades,
        AceOfSpades
    };
}
