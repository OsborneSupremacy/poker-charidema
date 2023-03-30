using Poker.Library.Cards;

namespace Poker.Library.Classic;

public record Deck : IDeck
{
    public Spot TwoOfHearts { get; }

    public Spot ThreeOfHearts { get; }

    public Spot FourOfHearts { get; }

    public Spot FiveOfHearts { get; }

    public Spot SixOfHearts { get; }

    public Spot SevenOfHearts { get; }

    public Spot EightOfHearts { get; }

    public Spot NineOfHearts { get; }

    public Spot TenOfHearts { get; }

    public Face JackOfHearts { get; }

    public Face QueenOfHearts { get; }

    public Face KingOfHearts { get; }

    public Spot AceOfHearts { get; }

    public Spot TwoOfDiamonds { get; }

    public Spot ThreeOfDiamonds { get; }

    public Spot FourOfDiamonds { get; }

    public Spot FiveOfDiamonds { get; }

    public Spot SixOfDiamonds { get; }

    public Spot SevenOfDiamonds { get; }

    public Spot EightOfDiamonds { get; }

    public Spot NineOfDiamonds { get; }

    public Spot TenOfDiamonds { get; }

    public Face JackOfDiamonds { get; }

    public Face QueenOfDiamonds { get; }

    public Face KingOfDiamonds { get; }

    public Spot AceOfDiamonds { get; }

    public Spot TwoOfClubs { get; }

    public Spot ThreeOfClubs { get; }

    public Spot FourOfClubs { get; }

    public Spot FiveOfClubs { get; }

    public Spot SixOfClubs { get; }

    public Spot SevenOfClubs { get; }

    public Spot EightOfClubs { get; }

    public Spot NineOfClubs { get; }

    public Spot TenOfClubs { get; }

    public Face JackOfClubs { get; }

    public Face QueenOfClubs { get; }

    public Face KingOfClubs { get; }

    public Spot AceOfClubs { get; }

    public Spot TwoOfSpades { get; }

    public Spot ThreeOfSpades { get; }

    public Spot FourOfSpades { get; }

    public Spot FiveOfSpades { get; }

    public Spot SixOfSpades { get; }

    public Spot SevenOfSpades { get; }

    public Spot EightOfSpades { get; }

    public Spot NineOfSpades { get; }

    public Spot TenOfSpades { get; }

    public Face JackOfSpades { get; }

    public Face QueenOfSpades { get; }

    public Face KingOfSpades { get; }

    public Spot AceOfSpades { get; }

    public List<ICard> Cards { get; init; }

    public uint NumberOfJokers { get; init; }

    public List<uint> CardRankValues { get; init; }

    public List<Joker> Jokers { get; init; }

    public Deck() : this(0) { }

    public Deck(uint numberOfJokers)
    {
        var suits = new Suits();
        var ranks = new Ranks();

        TwoOfHearts = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Two,
            Suit = suits.Hearts
        };

        ThreeOfHearts = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Three,
            Suit = suits.Hearts
        };

        FourOfHearts = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Four,
            Suit = suits.Hearts
        };

        FiveOfHearts = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Five,
            Suit = suits.Hearts
        };

        SixOfHearts = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Six,
            Suit = suits.Hearts
        };

        SevenOfHearts = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Seven,
            Suit = suits.Hearts
        };

        EightOfHearts = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Eight,
            Suit = suits.Hearts
        };

        NineOfHearts = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Nine,
            Suit = suits.Hearts
        };

        TenOfHearts = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Ten,
            Suit = suits.Hearts
        };

        JackOfHearts = new Face()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Jack,
            Suit = suits.Hearts,
            FaceDirection = FaceDirections.Left,
            HoldingObjects = new()
            {
                HoldingObject.Flower
            }
        };

        QueenOfHearts = new Face()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Queen,
            Suit = suits.Hearts,
            FaceDirection = FaceDirections.Left,
            HoldingObjects = new()
            {
                HoldingObject.Flower
            }
        };

        KingOfHearts = new Face()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.King,
            Suit = suits.Hearts,
            FaceDirection = FaceDirections.Left,
            HoldingObjects = new()
            {
                HoldingObject.Sword
            }
        };

        AceOfHearts = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Ace,
            Suit = suits.Hearts
        };

        TwoOfDiamonds = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Two,
            Suit = suits.Diamonds
        };

        ThreeOfDiamonds = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Three,
            Suit = suits.Diamonds
        };

        FourOfDiamonds = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Four,
            Suit = suits.Diamonds
        };

        FiveOfDiamonds = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Five,
            Suit = suits.Diamonds
        };

        SixOfDiamonds = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Six,
            Suit = suits.Diamonds
        };

        SevenOfDiamonds = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Seven,
            Suit = suits.Diamonds
        };

        EightOfDiamonds = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Eight,
            Suit = suits.Diamonds
        };

        NineOfDiamonds = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Nine,
            Suit = suits.Diamonds
        };

        TenOfDiamonds = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Ten,
            Suit = suits.Diamonds
        };

        JackOfDiamonds = new Face()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Jack,
            Suit = suits.Diamonds,
            FaceDirection = FaceDirections.Left,
            HoldingObjects = new()
            {
                HoldingObject.Flower
            }
        };

        QueenOfDiamonds = new Face()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Queen,
            Suit = suits.Diamonds,
            FaceDirection = FaceDirections.Left,
            HoldingObjects = new()
            {
                HoldingObject.Flower
            }
        };

        KingOfDiamonds = new Face()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.King,
            Suit = suits.Diamonds,
            FaceDirection = FaceDirections.Left,
            HoldingObjects = new()
            {
                HoldingObject.Sword
            }
        };

        AceOfDiamonds = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Ace,
            Suit = suits.Diamonds
        };

        TwoOfClubs = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Two,
            Suit = suits.Clubs
        };

        ThreeOfClubs = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Three,
            Suit = suits.Clubs
        };

        FourOfClubs = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Four,
            Suit = suits.Clubs
        };

        FiveOfClubs = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Five,
            Suit = suits.Clubs
        };

        SixOfClubs = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Six,
            Suit = suits.Clubs
        };

        SevenOfClubs = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Seven,
            Suit = suits.Clubs
        };

        EightOfClubs = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Eight,
            Suit = suits.Clubs
        };

        NineOfClubs = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Nine,
            Suit = suits.Clubs
        };

        TenOfClubs = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Ten,
            Suit = suits.Clubs
        };

        JackOfClubs = new Face()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Jack,
            Suit = suits.Clubs,
            FaceDirection = FaceDirections.Right,
            HoldingObjects = new()
            {
                HoldingObject.Flower
            }
        };

        QueenOfClubs = new Face()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Queen,
            Suit = suits.Clubs,
            FaceDirection = FaceDirections.Left,
            HoldingObjects = new()
            {
                HoldingObject.Flower
            }
        };

        KingOfClubs = new Face()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.King,
            Suit = suits.Clubs,
            FaceDirection = FaceDirections.Left,
            HoldingObjects = new()
            {
                HoldingObject.Sword
            }
        };

        AceOfClubs = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Ace,
            Suit = suits.Clubs
        };

        TwoOfSpades = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Two,
            Suit = suits.Spades
        };

        ThreeOfSpades = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Three,
            Suit = suits.Spades
        };

        FourOfSpades = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Four,
            Suit = suits.Spades
        };

        FiveOfSpades = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Five,
            Suit = suits.Spades
        };

        SixOfSpades = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Six,
            Suit = suits.Spades
        };

        SevenOfSpades = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Seven,
            Suit = suits.Spades
        };

        EightOfSpades = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Eight,
            Suit = suits.Spades
        };

        NineOfSpades = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Nine,
            Suit = suits.Spades
        };

        TenOfSpades = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Ten,
            Suit = suits.Spades
        };

        JackOfSpades = new Face()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Jack,
            Suit = suits.Spades,
            FaceDirection = FaceDirections.Right,
            HoldingObjects = new()
            {
                HoldingObject.Scepter
            }
        };

        QueenOfSpades = new Face()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Queen,
            Suit = suits.Spades,
            FaceDirection = FaceDirections.Right,
            HoldingObjects = new()
            {
                HoldingObject.Flower
            }
        };

        KingOfSpades = new Face()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.King,
            Suit = suits.Spades,
            FaceDirection = FaceDirections.Right,
            HoldingObjects = new()
            {
                HoldingObject.Sword
            }
        };

        AceOfSpades = new Spot()
        {
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Ace,
            Suit = suits.Spades
        };

        Cards = new List<ICard>()
        {
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

        CardRankValues = Cards
            .Where(x => x is IStandardCard)
            .Select(x => (x as IStandardCard)!.Rank.Value)
            .Distinct()
            .OrderByDescending(x => x)
            .ToList();

        NumberOfJokers = numberOfJokers;
        Jokers = new();

        for (uint j = 0; j < numberOfJokers; j++)
        {
            Joker joker = new();
            Cards.Add(joker);
            Jokers.Add(joker);
        }
    }
}
