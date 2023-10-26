
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

    public static Card TwoOfSpades { get; } = new()
    {
        Value = "2S",
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Two,
        Suit = Suits.Spades,
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

    public static Card TwoOfClubs { get; } = new()
    {
        Value = "2C",
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Two,
        Suit = Suits.Clubs,
        Holdings = new()
    };

    public static Card TwoOfDiamonds { get; } = new()
    {
        Value = "2D",
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Two,
        Suit = Suits.Diamonds,
        Holdings = new()
    };

    public static Card ThreeOfSpades { get; } = new()
    {
        Value = "3S",
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Three,
        Suit = Suits.Spades,
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

    public static Card ThreeOfClubs { get; } = new()
    {
        Value = "3C",
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Three,
        Suit = Suits.Clubs,
        Holdings = new()
    };

    public static Card ThreeOfDiamonds { get; } = new()
    {
        Value = "3D",
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Three,
        Suit = Suits.Diamonds,
        Holdings = new()
    };

    public static Card FourOfSpades { get; } = new()
    {
        Value = "4S",
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Four,
        Suit = Suits.Spades,
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

    public static Card FourOfClubs { get; } = new()
    {
        Value = "4C",
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Four,
        Suit = Suits.Clubs,
        Holdings = new()
    };

    public static Card FourOfDiamonds { get; } = new()
    {
        Value = "4D",
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Four,
        Suit = Suits.Diamonds,
        Holdings = new()
    };

    public static Card FiveOfSpades { get; } = new()
    {
        Value = "5S",
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Five,
        Suit = Suits.Spades,
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

    public static Card FiveOfClubs { get; } = new()
    {
        Value = "5C",
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Five,
        Suit = Suits.Clubs,
        Holdings = new()
    };

    public static Card FiveOfDiamonds { get; } = new()
    {
        Value = "5D",
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Five,
        Suit = Suits.Diamonds,
        Holdings = new()
    };

    public static Card SixOfSpades { get; } = new()
    {
        Value = "6S",
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Six,
        Suit = Suits.Spades,
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

    public static Card SixOfClubs { get; } = new()
    {
        Value = "6C",
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Six,
        Suit = Suits.Clubs,
        Holdings = new()
    };

    public static Card SixOfDiamonds { get; } = new()
    {
        Value = "6D",
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Six,
        Suit = Suits.Diamonds,
        Holdings = new()
    };

    public static Card SevenOfSpades { get; } = new()
    {
        Value = "7S",
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Seven,
        Suit = Suits.Spades,
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

    public static Card SevenOfClubs { get; } = new()
    {
        Value = "7C",
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Seven,
        Suit = Suits.Clubs,
        Holdings = new()
    };

    public static Card SevenOfDiamonds { get; } = new()
    {
        Value = "7D",
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Seven,
        Suit = Suits.Diamonds,
        Holdings = new()
    };

    public static Card EightOfSpades { get; } = new()
    {
        Value = "8S",
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Eight,
        Suit = Suits.Spades,
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

    public static Card EightOfClubs { get; } = new()
    {
        Value = "8C",
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Eight,
        Suit = Suits.Clubs,
        Holdings = new()
    };

    public static Card EightOfDiamonds { get; } = new()
    {
        Value = "8D",
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Eight,
        Suit = Suits.Diamonds,
        Holdings = new()
    };

    public static Card NineOfSpades { get; } = new()
    {
        Value = "9S",
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Nine,
        Suit = Suits.Spades,
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

    public static Card NineOfClubs { get; } = new()
    {
        Value = "9C",
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Nine,
        Suit = Suits.Clubs,
        Holdings = new()
    };

    public static Card NineOfDiamonds { get; } = new()
    {
        Value = "9D",
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Nine,
        Suit = Suits.Diamonds,
        Holdings = new()
    };

    public static Card TenOfSpades { get; } = new()
    {
        Value = "10S",
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Ten,
        Suit = Suits.Spades,
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

    public static Card TenOfClubs { get; } = new()
    {
        Value = "10C",
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Ten,
        Suit = Suits.Clubs,
        Holdings = new()
    };

    public static Card TenOfDiamonds { get; } = new()
    {
        Value = "10D",
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Ten,
        Suit = Suits.Diamonds,
        Holdings = new()
    };

    public static Card JackOfSpades { get; } = new()
    {
        Value = "11S",
        CardType = CardTypes.Face,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Jack,
        Suit = Suits.Spades,
        Holdings = new()
    };

    public static Card JackOfHearts { get; } = new()
    {
        Value = "11H",
        CardType = CardTypes.Face,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Jack,
        Suit = Suits.Hearts,
        Holdings = new()
    };

    public static Card JackOfClubs { get; } = new()
    {
        Value = "11C",
        CardType = CardTypes.Face,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Jack,
        Suit = Suits.Clubs,
        Holdings = new()
    };

    public static Card JackOfDiamonds { get; } = new()
    {
        Value = "11D",
        CardType = CardTypes.Face,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Jack,
        Suit = Suits.Diamonds,
        Holdings = new()
    };

    public static Card QueenOfSpades { get; } = new()
    {
        Value = "12S",
        CardType = CardTypes.Face,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Queen,
        Suit = Suits.Spades,
        Holdings = new()
    };

    public static Card QueenOfHearts { get; } = new()
    {
        Value = "12H",
        CardType = CardTypes.Face,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Queen,
        Suit = Suits.Hearts,
        Holdings = new()
    };

    public static Card QueenOfClubs { get; } = new()
    {
        Value = "12C",
        CardType = CardTypes.Face,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Queen,
        Suit = Suits.Clubs,
        Holdings = new()
    };

    public static Card QueenOfDiamonds { get; } = new()
    {
        Value = "12D",
        CardType = CardTypes.Face,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Queen,
        Suit = Suits.Diamonds,
        Holdings = new()
    };

    public static Card KingOfSpades { get; } = new()
    {
        Value = "13S",
        CardType = CardTypes.Face,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.King,
        Suit = Suits.Spades,
        Holdings = new()
    };

    public static Card KingOfHearts { get; } = new()
    {
        Value = "13H",
        CardType = CardTypes.Face,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.King,
        Suit = Suits.Hearts,
        Holdings = new()
    };

    public static Card KingOfClubs { get; } = new()
    {
        Value = "13C",
        CardType = CardTypes.Face,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.King,
        Suit = Suits.Clubs,
        Holdings = new()
    };

    public static Card KingOfDiamonds { get; } = new()
    {
        Value = "13D",
        CardType = CardTypes.Face,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.King,
        Suit = Suits.Diamonds,
        Holdings = new()
    };

    public static Card AceOfSpades { get; } = new()
    {
        Value = "14S",
        CardType = CardTypes.Ace,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Ace,
        Suit = Suits.Spades,
        Holdings = new()
    };

    public static Card AceOfHearts { get; } = new()
    {
        Value = "14H",
        CardType = CardTypes.Ace,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Ace,
        Suit = Suits.Hearts,
        Holdings = new()
    };

    public static Card AceOfClubs { get; } = new()
    {
        Value = "14C",
        CardType = CardTypes.Ace,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Ace,
        Suit = Suits.Clubs,
        Holdings = new()
    };

    public static Card AceOfDiamonds { get; } = new()
    {
        Value = "14D",
        CardType = CardTypes.Ace,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Rank = Ranks.Ace,
        Suit = Suits.Diamonds,
        Holdings = new()
    };

    public static Card CreateJoker() => new()
    {
        Value = "W", // for "wild". "J" is already taken by Jack
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
