namespace Poker.Domain.Classic;

public record Deck
{
    public Card TwoOfHearts { get; }

    public Card ThreeOfHearts { get; }

    public Card FourOfHearts { get; }

    public Card FiveOfHearts { get; }

    public Card SixOfHearts { get; }

    public Card SevenOfHearts { get; }

    public Card EightOfHearts { get; }

    public Card NineOfHearts { get; }

    public Card TenOfHearts { get; }

    public Card JackOfHearts { get; }

    public Card QueenOfHearts { get; }

    public Card KingOfHearts { get; }

    public Card AceOfHearts { get; }

    public Card TwoOfDiamonds { get; }

    public Card ThreeOfDiamonds { get; }

    public Card FourOfDiamonds { get; }

    public Card FiveOfDiamonds { get; }

    public Card SixOfDiamonds { get; }

    public Card SevenOfDiamonds { get; }

    public Card EightOfDiamonds { get; }

    public Card NineOfDiamonds { get; }

    public Card TenOfDiamonds { get; }

    public Card JackOfDiamonds { get; }

    public Card QueenOfDiamonds { get; }

    public Card KingOfDiamonds { get; }

    public Card AceOfDiamonds { get; }

    public Card TwoOfClubs { get; }

    public Card ThreeOfClubs { get; }

    public Card FourOfClubs { get; }

    public Card FiveOfClubs { get; }

    public Card SixOfClubs { get; }

    public Card SevenOfClubs { get; }

    public Card EightOfClubs { get; }

    public Card NineOfClubs { get; }

    public Card TenOfClubs { get; }

    public Card JackOfClubs { get; }

    public Card QueenOfClubs { get; }

    public Card KingOfClubs { get; }

    public Card AceOfClubs { get; }

    public Card TwoOfSpades { get; }

    public Card ThreeOfSpades { get; }

    public Card FourOfSpades { get; }

    public Card FiveOfSpades { get; }

    public Card SixOfSpades { get; }

    public Card SevenOfSpades { get; }

    public Card EightOfSpades { get; }

    public Card NineOfSpades { get; }

    public Card TenOfSpades { get; }

    public Card JackOfSpades { get; }

    public Card QueenOfSpades { get; }

    public Card KingOfSpades { get; }

    public Card AceOfSpades { get; }

    public List<Card> Cards { get; init; }

    public uint NumberOfJokers { get; init; }

    public List<uint> CardRankValues { get; init; }

    public List<Card> Jokers { get; init; }

    public List<uint> CardSuitPriorities { get; init; }

    public Deck() : this(0) { }

    public Deck(uint numberOfJokers)
    {
        var suits = new Suits();
        var ranks = new Ranks();

        TwoOfHearts = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            CardType = CardTypes.Spot,
            FaceDirection = FaceDirections.NotApplicable,
            IsWild = false,
            Rank = ranks.Two,
            Suit = suits.Hearts,
            Holdings = new()
        };

        ThreeOfHearts = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            CardType = CardTypes.Spot,
            FaceDirection = FaceDirections.NotApplicable,
            IsWild = false,
            Rank = ranks.Three,
            Suit = suits.Hearts,
            Holdings = new()
        };

        FourOfHearts = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            CardType = CardTypes.Spot,
            FaceDirection = FaceDirections.NotApplicable,
            IsWild = false,
            Rank = ranks.Four,
            Suit = suits.Hearts,
            Holdings = new()
        };

        FiveOfHearts = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            CardType = CardTypes.Spot,
            FaceDirection = FaceDirections.NotApplicable,
            IsWild = false,
            Rank = ranks.Five,
            Suit = suits.Hearts,
            Holdings = new()
        };

        SixOfHearts = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            CardType = CardTypes.Spot,
            FaceDirection = FaceDirections.NotApplicable,
            IsWild = false,
            Rank = ranks.Six,
            Suit = suits.Hearts,
            Holdings = new()
        };

        SevenOfHearts = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            CardType = CardTypes.Spot,
            FaceDirection = FaceDirections.NotApplicable,
            IsWild = false,
            Rank = ranks.Seven,
            Suit = suits.Hearts,
            Holdings = new()
        };

        EightOfHearts = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            CardType = CardTypes.Spot,
            FaceDirection = FaceDirections.NotApplicable,
            IsWild = false,
            Rank = ranks.Eight,
            Suit = suits.Hearts,
            Holdings = new()
        };

        NineOfHearts = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            CardType = CardTypes.Spot,
            FaceDirection = FaceDirections.NotApplicable,
            IsWild = false,
            Rank = ranks.Nine,
            Suit = suits.Hearts,
            Holdings = new()
        };

        TenOfHearts = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            CardType = CardTypes.Spot,
            FaceDirection = FaceDirections.NotApplicable,
            IsWild = false,
            Rank = ranks.Ten,
            Suit = suits.Hearts,
            Holdings = new()
        };

        JackOfHearts = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            CardType = CardTypes.Face,
            IsWild = false,
            Rank = ranks.Jack,
            Suit = suits.Hearts,
            FaceDirection = FaceDirections.Left,
            Holdings = new()
            {
                Holding.Flower
            }
        };

        QueenOfHearts = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            CardType = CardTypes.Face,
            IsWild = false,
            Rank = ranks.Queen,
            Suit = suits.Hearts,
            FaceDirection = FaceDirections.Left,
            Holdings = new()
            {
                Holding.Flower
            }
        };

        KingOfHearts = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            CardType = CardTypes.Face,
            IsWild = false,
            Rank = ranks.King,
            Suit = suits.Hearts,
            FaceDirection = FaceDirections.Left,
            Holdings = new()
            {
                Holding.Sword
            }
        };

        AceOfHearts = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            CardType = CardTypes.Ace,
            FaceDirection = FaceDirections.NotApplicable,
            Rank = ranks.Ace,
            Suit = suits.Hearts,
            Holdings = new()
        };

        TwoOfDiamonds = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            CardType = CardTypes.Spot,
            FaceDirection = FaceDirections.NotApplicable,
            Rank = ranks.Two,
            Suit = suits.Diamonds,
            Holdings = new()
        };

        ThreeOfDiamonds = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            CardType = CardTypes.Spot,
            FaceDirection = FaceDirections.NotApplicable,
            Rank = ranks.Three,
            Suit = suits.Diamonds,
            Holdings = new()
        };

        FourOfDiamonds = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            CardType = CardTypes.Spot,
            FaceDirection = FaceDirections.NotApplicable,
            Rank = ranks.Four,
            Suit = suits.Diamonds,
            Holdings = new()
        };

        FiveOfDiamonds = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            CardType = CardTypes.Spot,
            FaceDirection = FaceDirections.NotApplicable,
            Rank = ranks.Five,
            Suit = suits.Diamonds,
            Holdings = new()
        };

        SixOfDiamonds = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            CardType = CardTypes.Spot,
            FaceDirection = FaceDirections.NotApplicable,
            Rank = ranks.Six,
            Suit = suits.Diamonds,
            Holdings = new()
        };

        SevenOfDiamonds = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            CardType = CardTypes.Spot,
            FaceDirection = FaceDirections.NotApplicable,
            Rank = ranks.Seven,
            Suit = suits.Diamonds,
            Holdings = new()
        };

        EightOfDiamonds = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            CardType = CardTypes.Spot,
            FaceDirection = FaceDirections.NotApplicable,
            Rank = ranks.Eight,
            Suit = suits.Diamonds,
            Holdings = new()
        };

        NineOfDiamonds = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            CardType = CardTypes.Spot,
            FaceDirection = FaceDirections.NotApplicable,
            Rank = ranks.Nine,
            Suit = suits.Diamonds,
            Holdings = new()
        };

        TenOfDiamonds = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            CardType = CardTypes.Spot,
            FaceDirection = FaceDirections.NotApplicable,
            Rank = ranks.Ten,
            Suit = suits.Diamonds,
            Holdings = new()
        };

        JackOfDiamonds = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            CardType = CardTypes.Face,
            Rank = ranks.Jack,
            Suit = suits.Diamonds,
            FaceDirection = FaceDirections.Left,
            Holdings = new()
            {
                Holding.Flower
            }
        };

        QueenOfDiamonds = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            CardType = CardTypes.Face,
            Rank = ranks.Queen,
            Suit = suits.Diamonds,
            FaceDirection = FaceDirections.Left,
            Holdings = new()
            {
                Holding.Flower
            }
        };

        KingOfDiamonds = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            CardType = CardTypes.Face,
            Rank = ranks.King,
            Suit = suits.Diamonds,
            FaceDirection = FaceDirections.Left,
            Holdings = new()
            {
                Holding.Sword
            }
        };

        AceOfDiamonds = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            CardType = CardTypes.Ace,
            IsWild = false,
            Rank = ranks.Ace,
            Suit = suits.Diamonds,
            FaceDirection = FaceDirections.NotApplicable,
            Holdings = new()
        };

        TwoOfClubs = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Two,
            Suit = suits.Clubs,
            FaceDirection = FaceDirections.NotApplicable,
            Holdings = new(),
            CardType = CardTypes.Spot
        };

        ThreeOfClubs = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Three,
            Suit = suits.Clubs,
            FaceDirection = FaceDirections.NotApplicable,
            Holdings = new(),
            CardType = CardTypes.Spot
        };

        FourOfClubs = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Four,
            Suit = suits.Clubs,
            FaceDirection = FaceDirections.NotApplicable,
            Holdings = new(),
            CardType = CardTypes.Spot
        };

        FiveOfClubs = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Five,
            Suit = suits.Clubs,
            FaceDirection = FaceDirections.NotApplicable,
            Holdings = new(),
            CardType = CardTypes.Spot
        };

        SixOfClubs = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Six,
            Suit = suits.Clubs,
            FaceDirection = FaceDirections.NotApplicable,
            Holdings = new(),
            CardType = CardTypes.Spot
        };

        SevenOfClubs = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Seven,
            Suit = suits.Clubs,
            FaceDirection = FaceDirections.NotApplicable,
            Holdings = new(),
            CardType = CardTypes.Spot
        };

        EightOfClubs = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Eight,
            Suit = suits.Clubs,
            FaceDirection = FaceDirections.NotApplicable,
            Holdings = new(),
            CardType = CardTypes.Spot
        };

        NineOfClubs = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Nine,
            Suit = suits.Clubs,
            FaceDirection = FaceDirections.NotApplicable,
            Holdings = new(),
            CardType = CardTypes.Spot
        };

        TenOfClubs = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Ten,
            Suit = suits.Clubs,
            FaceDirection = FaceDirections.NotApplicable,
            Holdings = new(),
            CardType = CardTypes.Spot
        };

        JackOfClubs = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            CardType = CardTypes.Face,
            Rank = ranks.Jack,
            Suit = suits.Clubs,
            FaceDirection = FaceDirections.Right,
            Holdings = new()
            {
                Holding.Flower
            }
        };

        QueenOfClubs = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            CardType = CardTypes.Face,
            Rank = ranks.Queen,
            Suit = suits.Clubs,
            FaceDirection = FaceDirections.Left,
            Holdings = new()
            {
                Holding.Flower
            }
        };

        KingOfClubs = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            CardType = CardTypes.Face,
            Rank = ranks.King,
            Suit = suits.Clubs,
            FaceDirection = FaceDirections.Left,
            Holdings = new()
            {
                Holding.Sword
            }
        };

        AceOfClubs = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            CardType = CardTypes.Ace,
            Rank = ranks.Ace,
            Suit = suits.Clubs,
            FaceDirection = FaceDirections.NotApplicable,
            Holdings = new()
        };

        TwoOfSpades = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Two,
            Suit = suits.Spades,
            FaceDirection = FaceDirections.NotApplicable,
            CardType = CardTypes.Spot,
            Holdings = new()
        };

        ThreeOfSpades = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Three,
            Suit = suits.Spades,
            FaceDirection = FaceDirections.NotApplicable,
            CardType = CardTypes.Spot,
            Holdings = new()
        };

        FourOfSpades = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Four,
            Suit = suits.Spades,
            FaceDirection = FaceDirections.NotApplicable,
            CardType = CardTypes.Spot,
            Holdings = new()
        };

        FiveOfSpades = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Five,
            Suit = suits.Spades,
            FaceDirection = FaceDirections.NotApplicable,
            CardType = CardTypes.Spot,
            Holdings = new()
        };

        SixOfSpades = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Six,
            Suit = suits.Spades,
            FaceDirection = FaceDirections.NotApplicable,
            CardType = CardTypes.Spot,
            Holdings = new()
        };

        SevenOfSpades = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Seven,
            Suit = suits.Spades,
            FaceDirection = FaceDirections.NotApplicable,
            CardType = CardTypes.Spot,
            Holdings = new()
        };

        EightOfSpades = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Eight,
            Suit = suits.Spades,
            FaceDirection = FaceDirections.NotApplicable,
            CardType = CardTypes.Spot,
            Holdings = new()
        };

        NineOfSpades = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Nine,
            Suit = suits.Spades,
            FaceDirection = FaceDirections.NotApplicable,
            CardType = CardTypes.Spot,
            Holdings = new()
        };

        TenOfSpades = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            Rank = ranks.Ten,
            Suit = suits.Spades,
            FaceDirection = FaceDirections.NotApplicable,
            CardType = CardTypes.Spot,
            Holdings = new()
        };

        JackOfSpades = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            CardType = CardTypes.Face,
            Rank = ranks.Jack,
            Suit = suits.Spades,
            FaceDirection = FaceDirections.Right,
            Holdings = new()
            {
                Holding.Scepter
            }
        };

        QueenOfSpades = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            CardType = CardTypes.Face,
            Rank = ranks.Queen,
            Suit = suits.Spades,
            FaceDirection = FaceDirections.Right,
            Holdings = new()
            {
                Holding.Flower
            }
        };

        KingOfSpades = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            CardType = CardTypes.Face,
            Rank = ranks.King,
            Suit = suits.Spades,
            FaceDirection = FaceDirections.Right,
            Holdings = new()
            {
                Holding.Sword
            }
        };

        AceOfSpades = new Card
        {
            Id = Guid.NewGuid(),
            CardOrientation = CardOrientations.Facedown,
            IsWild = false,
            CardType = CardTypes.Ace,
            Rank = ranks.Ace,
            Suit = suits.Spades,
            FaceDirection = FaceDirections.NotApplicable,
            Holdings = new()
        };

        Cards = new List<Card>()
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
            .Where(x => x.Rank is not null)
            .Select(x => x.Rank!.Value)
            .Distinct()
            .OrderByDescending(x => x)
            .ToList();

        CardSuitPriorities = Cards
            .Where(x => x.Suit is not null)
            .Select(x => x.Suit!.Priority)
            .Distinct()
            .OrderByDescending(x => x)
            .ToList();

        NumberOfJokers = numberOfJokers;
        Jokers = new();

        for (uint j = 0; j < numberOfJokers; j++)
        {
            Card joker = new Card {
                Id = Guid.NewGuid(),
                CardOrientation = CardOrientations.Facedown,
                CardType = CardTypes.Joker,
                IsWild = true,
                Rank = null,
                Suit = null,
                FaceDirection = FaceDirections.NotApplicable,
                Holdings = new()
            };
            Cards.Add(joker);
            Jokers.Add(joker);
        }
    }
}
