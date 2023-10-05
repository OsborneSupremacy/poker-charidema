﻿namespace Poker.Domain.Classic;

public record Cards
{
    public static Card Empty { get; } = new Card
    {
        Id = Guid.Empty,
        Value = string.Empty,
        CardOrientation = CardOrientations.Empty,
        CardType = CardTypes.Empty,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Impersonating = new Card { 
            Id = Guid.Empty,
            Value = string.Empty,
            CardOrientation = CardOrientations.Empty,
            CardType = CardTypes.Empty,
            FaceDirection = FaceDirections.NotApplicable,
            IsWild = false,
            Impersonating = default!,
            Rank = Ranks.Empty,
            Suit = Suits.Empty,
            Holdings = new()
        },
        Rank = Ranks.Empty,
        Suit = Suits.Empty,
        Holdings = new()
    };

    public static Card TwoOfHearts { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "2H",
        CardOrientation = CardOrientations.Facedown,
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Impersonating = Empty,
        Rank = Ranks.Two,
        Suit = Suits.Hearts,
        Holdings = new()
    };

    public static Card ThreeOfHearts { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "3H",
        CardOrientation = CardOrientations.Facedown,
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Impersonating = Empty,
        Rank = Ranks.Three,
        Suit = Suits.Hearts,
        Holdings = new()
    };

    public static Card FourOfHearts { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "4H",
        CardOrientation = CardOrientations.Facedown,
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Impersonating = Empty,
        Rank = Ranks.Four,
        Suit = Suits.Hearts,
        Holdings = new()
    };

    public static Card FiveOfHearts { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "5H",
        CardOrientation = CardOrientations.Facedown,
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Impersonating = Empty,
        Rank = Ranks.Five,
        Suit = Suits.Hearts,
        Holdings = new()
    };

    public static Card SixOfHearts { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "6H",
        CardOrientation = CardOrientations.Facedown,
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Impersonating = Empty,
        Rank = Ranks.Six,
        Suit = Suits.Hearts,
        Holdings = new()
    };

    public static Card SevenOfHearts { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "7H",
        CardOrientation = CardOrientations.Facedown,
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Impersonating = Empty,
        Rank = Ranks.Seven,
        Suit = Suits.Hearts,
        Holdings = new()
    };

    public static Card EightOfHearts { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "8H",
        CardOrientation = CardOrientations.Facedown,
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Impersonating = Empty,
        Rank = Ranks.Eight,
        Suit = Suits.Hearts,
        Holdings = new()
    };

    public static Card NineOfHearts { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "9H",
        CardOrientation = CardOrientations.Facedown,
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Impersonating = Empty,
        Rank = Ranks.Nine,
        Suit = Suits.Hearts,
        Holdings = new()
    };

    public static Card TenOfHearts { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "10H",
        CardOrientation = CardOrientations.Facedown,
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        IsWild = false,
        Impersonating = Empty,
        Rank = Ranks.Ten,
        Suit = Suits.Hearts,
        Holdings = new()
    };

    public static Card JackOfHearts { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "JH",
        CardOrientation = CardOrientations.Facedown,
        CardType = CardTypes.Face,
        IsWild = false,
        Impersonating = Empty,
        Rank = Ranks.Jack,
        Suit = Suits.Hearts,
        FaceDirection = FaceDirections.Left,
        Holdings = new()
            {
                Holding.Flower
            }
    };

    public static Card QueenOfHearts { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "QH",
        CardOrientation = CardOrientations.Facedown,
        CardType = CardTypes.Face,
        IsWild = false,
        Impersonating = Empty,
        Rank = Ranks.Queen,
        Suit = Suits.Hearts,
        FaceDirection = FaceDirections.Left,
        Holdings = new()
            {
                Holding.Flower
            }
    };

    public static Card KingOfHearts { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "KH",
        CardOrientation = CardOrientations.Facedown,
        CardType = CardTypes.Face,
        IsWild = false,
        Impersonating = Empty,
        Rank = Ranks.King,
        Suit = Suits.Hearts,
        FaceDirection = FaceDirections.Left,
        Holdings = new()
            {
                Holding.Sword
            }
    };

    public static Card AceOfHearts { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "AH",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        CardType = CardTypes.Ace,
        FaceDirection = FaceDirections.NotApplicable,
        Rank = Ranks.Ace,
        Suit = Suits.Hearts,
        Holdings = new()
    };

    public static Card TwoOfDiamonds { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "2D",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        Rank = Ranks.Two,
        Suit = Suits.Diamonds,
        Holdings = new()
    };

    public static Card ThreeOfDiamonds { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "3D",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        Rank = Ranks.Three,
        Suit = Suits.Diamonds,
        Holdings = new()
    };

    public static Card FourOfDiamonds { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "4D",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        Rank = Ranks.Four,
        Suit = Suits.Diamonds,
        Holdings = new()
    };

    public static Card FiveOfDiamonds { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "5D",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        Rank = Ranks.Five,
        Suit = Suits.Diamonds,
        Holdings = new()
    };

    public static Card SixOfDiamonds { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "6D",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        Rank = Ranks.Six,
        Suit = Suits.Diamonds,
        Holdings = new()
    };

    public static Card SevenOfDiamonds { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "7D",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        Rank = Ranks.Seven,
        Suit = Suits.Diamonds,
        Holdings = new()
    };

    public static Card EightOfDiamonds { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "8D",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        Rank = Ranks.Eight,
        Suit = Suits.Diamonds,
        Holdings = new()
    };

    public static Card NineOfDiamonds { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "9D",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        Rank = Ranks.Nine,
        Suit = Suits.Diamonds,
        Holdings = new()
    };

    public static Card TenOfDiamonds { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "10D",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        CardType = CardTypes.Spot,
        FaceDirection = FaceDirections.NotApplicable,
        Rank = Ranks.Ten,
        Suit = Suits.Diamonds,
        Holdings = new()
    };

    public static Card JackOfDiamonds { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "JD",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        CardType = CardTypes.Face,
        Rank = Ranks.Jack,
        Suit = Suits.Diamonds,
        FaceDirection = FaceDirections.Left,
        Holdings = new()
            {
                Holding.Flower
            }
    };

    public static Card QueenOfDiamonds { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "QD",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        CardType = CardTypes.Face,
        Rank = Ranks.Queen,
        Suit = Suits.Diamonds,
        FaceDirection = FaceDirections.Left,
        Holdings = new()
            {
                Holding.Flower
            }
    };

    public static Card KingOfDiamonds { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "KD",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        CardType = CardTypes.Face,
        Rank = Ranks.King,
        Suit = Suits.Diamonds,
        FaceDirection = FaceDirections.Left,
        Holdings = new()
            {
                Holding.Sword
            }
    };

    public static Card AceOfDiamonds { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "AD",
        CardOrientation = CardOrientations.Facedown,
        CardType = CardTypes.Ace,
        IsWild = false,
        Impersonating = Empty,
        Rank = Ranks.Ace,
        Suit = Suits.Diamonds,
        FaceDirection = FaceDirections.NotApplicable,
        Holdings = new()
    };

    public static Card TwoOfClubs { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "2C",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        Rank = Ranks.Two,
        Suit = Suits.Clubs,
        FaceDirection = FaceDirections.NotApplicable,
        Holdings = new(),
        CardType = CardTypes.Spot
    };

    public static Card ThreeOfClubs { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "3C",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        Rank = Ranks.Three,
        Suit = Suits.Clubs,
        FaceDirection = FaceDirections.NotApplicable,
        Holdings = new(),
        CardType = CardTypes.Spot
    };

    public static Card FourOfClubs { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "4C",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        Rank = Ranks.Four,
        Suit = Suits.Clubs,
        FaceDirection = FaceDirections.NotApplicable,
        Holdings = new(),
        CardType = CardTypes.Spot
    };

    public static Card FiveOfClubs { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "5C",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        Rank = Ranks.Five,
        Suit = Suits.Clubs,
        FaceDirection = FaceDirections.NotApplicable,
        Holdings = new(),
        CardType = CardTypes.Spot
    };

    public static Card SixOfClubs { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "6C",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        Rank = Ranks.Six,
        Suit = Suits.Clubs,
        FaceDirection = FaceDirections.NotApplicable,
        Holdings = new(),
        CardType = CardTypes.Spot
    };

    public static Card SevenOfClubs { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "7C",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        Rank = Ranks.Seven,
        Suit = Suits.Clubs,
        FaceDirection = FaceDirections.NotApplicable,
        Holdings = new(),
        CardType = CardTypes.Spot
    };

    public static Card EightOfClubs { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "8C",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        Rank = Ranks.Eight,
        Suit = Suits.Clubs,
        FaceDirection = FaceDirections.NotApplicable,
        Holdings = new(),
        CardType = CardTypes.Spot
    };

    public static Card NineOfClubs { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "9C",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        Rank = Ranks.Nine,
        Suit = Suits.Clubs,
        FaceDirection = FaceDirections.NotApplicable,
        Holdings = new(),
        CardType = CardTypes.Spot
    };

    public static Card TenOfClubs { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "10C",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        Rank = Ranks.Ten,
        Suit = Suits.Clubs,
        FaceDirection = FaceDirections.NotApplicable,
        Holdings = new(),
        CardType = CardTypes.Spot
    };

    public static Card JackOfClubs { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "JC",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        CardType = CardTypes.Face,
        Rank = Ranks.Jack,
        Suit = Suits.Clubs,
        FaceDirection = FaceDirections.Right,
        Holdings = new()
            {
                Holding.Flower
            }
    };

    public static Card QueenOfClubs { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "QC",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        CardType = CardTypes.Face,
        Rank = Ranks.Queen,
        Suit = Suits.Clubs,
        FaceDirection = FaceDirections.Left,
        Holdings = new()
            {
                Holding.Flower
            }
    };

    public static Card KingOfClubs { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "KC",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        CardType = CardTypes.Face,
        Rank = Ranks.King,
        Suit = Suits.Clubs,
        FaceDirection = FaceDirections.Left,
        Holdings = new()
            {
                Holding.Sword
            }
    };

    public static Card AceOfClubs { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "AC",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        CardType = CardTypes.Ace,
        Rank = Ranks.Ace,
        Suit = Suits.Clubs,
        FaceDirection = FaceDirections.NotApplicable,
        Holdings = new()
    };

    public static Card TwoOfSpades { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "2S",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        Rank = Ranks.Two,
        Suit = Suits.Spades,
        FaceDirection = FaceDirections.NotApplicable,
        CardType = CardTypes.Spot,
        Holdings = new()
    };

    public static Card ThreeOfSpades { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "3S",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        Rank = Ranks.Three,
        Suit = Suits.Spades,
        FaceDirection = FaceDirections.NotApplicable,
        CardType = CardTypes.Spot,
        Holdings = new()
    };

    public static Card FourOfSpades { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "4S",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        Rank = Ranks.Four,
        Suit = Suits.Spades,
        FaceDirection = FaceDirections.NotApplicable,
        CardType = CardTypes.Spot,
        Holdings = new()
    };

    public static Card FiveOfSpades { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "5S",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        Rank = Ranks.Five,
        Suit = Suits.Spades,
        FaceDirection = FaceDirections.NotApplicable,
        CardType = CardTypes.Spot,
        Holdings = new()
    };

    public static Card SixOfSpades { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "6S",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        Rank = Ranks.Six,
        Suit = Suits.Spades,
        FaceDirection = FaceDirections.NotApplicable,
        CardType = CardTypes.Spot,
        Holdings = new()
    };

    public static Card SevenOfSpades { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "7S",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        Rank = Ranks.Seven,
        Suit = Suits.Spades,
        FaceDirection = FaceDirections.NotApplicable,
        CardType = CardTypes.Spot,
        Holdings = new()
    };

    public static Card EightOfSpades { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "8S",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        Rank = Ranks.Eight,
        Suit = Suits.Spades,
        FaceDirection = FaceDirections.NotApplicable,
        CardType = CardTypes.Spot,
        Holdings = new()
    };

    public static Card NineOfSpades { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "9S",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        Rank = Ranks.Nine,
        Suit = Suits.Spades,
        FaceDirection = FaceDirections.NotApplicable,
        CardType = CardTypes.Spot,
        Holdings = new()
    };

    public static Card TenOfSpades { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "10S",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        Rank = Ranks.Ten,
        Suit = Suits.Spades,
        FaceDirection = FaceDirections.NotApplicable,
        CardType = CardTypes.Spot,
        Holdings = new()
    };

    public static Card JackOfSpades { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "JS",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        CardType = CardTypes.Face,
        Rank = Ranks.Jack,
        Suit = Suits.Spades,
        FaceDirection = FaceDirections.Right,
        Holdings = new()
            {
                Holding.Scepter
            }
    };

    public static Card QueenOfSpades { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "QS",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        CardType = CardTypes.Face,
        Rank = Ranks.Queen,
        Suit = Suits.Spades,
        FaceDirection = FaceDirections.Right,
        Holdings = new()
            {
                Holding.Flower
            }
    };

    public static Card KingOfSpades { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "KS",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        CardType = CardTypes.Face,
        Rank = Ranks.King,
        Suit = Suits.Spades,
        FaceDirection = FaceDirections.Right,
        Holdings = new()
            {
                Holding.Sword
            }
    };

    public static Card AceOfSpades { get; } = new Card
    {
        Id = Guid.NewGuid(),
        Value = "AS",
        CardOrientation = CardOrientations.Facedown,
        IsWild = false,
        Impersonating = Empty,
        CardType = CardTypes.Ace,
        Rank = Ranks.Ace,
        Suit = Suits.Spades,
        FaceDirection = FaceDirections.NotApplicable,
        Holdings = new()
    };

    public static Card CreateJoker() => new()
    {
        Id = Guid.NewGuid(),
        Value = "J",
        CardOrientation = CardOrientations.Facedown,
        IsWild = true,
        Impersonating = Empty,
        CardType = CardTypes.Joker,
        Rank = Ranks.Empty,
        Suit = Suits.Empty,
        FaceDirection = FaceDirections.NotApplicable,
        Holdings = new()
    };

    public static List<Card> All { get; } = new() {
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
