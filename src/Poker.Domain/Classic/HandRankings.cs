namespace Poker.Domain.Classic;

public record HandRankings
{
    public HandRanking NoHand { get; }

    public HandRanking HighCard { get; }

    public HandRanking Pair { get; }

    public HandRanking TwoPair { get; }

    public HandRanking ThreeOfAKind { get; }

    public HandRanking Straight { get; }

    public HandRanking Flush { get; }

    public HandRanking FullHouse { get; }

    public HandRanking FourOfAKind { get; }

    public HandRanking StraightFlush { get; }

    public HandRanking RoyalFlush { get; }

    public HandRanking FiveOfAKind { get; }

    public List<HandRanking> HandRankingsList { get; }

    public HandRankings() {

        var ranks = new Ranks();

        NoHand = new HandRanking
        {
            Name = "No Hand",
            Value = 0,
            PrimaryMatchesCount = 0,
            SecondaryMatchesCount = 0,
            Sequence = false,
            Uniform = false,
            SequenceMinRank = null
        };

        HighCard = new HandRanking {
            Name = "High Card",
            Value = 1,
            PrimaryMatchesCount = 1,
            SecondaryMatchesCount = 0,
            Sequence = false,
            Uniform = false,
            SequenceMinRank = null
        };

        Pair = new HandRanking {
            Name = "Pair",
            Value = 2,
            PrimaryMatchesCount = 2,
            SecondaryMatchesCount = 0,
            Sequence = false,
            Uniform = false,
            SequenceMinRank = null
        };

        TwoPair = new HandRanking {
            Name = "Two Pair",
            Value = 3,
            PrimaryMatchesCount = 2,
            SecondaryMatchesCount = 2,
            Sequence = false,
            Uniform = false,
            SequenceMinRank = null
        };

        ThreeOfAKind = new HandRanking {
            Name = "Three of a Kind",
            Value = 4,
            PrimaryMatchesCount = 3,
            SecondaryMatchesCount = 0,
            Sequence = false,
            Uniform = false,
            SequenceMinRank = null
        };

        Straight = new HandRanking {
            Name = "Straight",
            Value = 5,
            PrimaryMatchesCount = 0,
            SecondaryMatchesCount = 0,
            Sequence = true,
            Uniform = false,
            SequenceMinRank = ranks.Two
        };

        Flush = new HandRanking {
            Name = "Flush",
            Value = 6,
            PrimaryMatchesCount = 0,
            SecondaryMatchesCount = 0,
            Sequence = false,
            Uniform = true,
            SequenceMinRank = null
        };

        FullHouse = new HandRanking {
            Name = "Full House",
            Value = 7,
            PrimaryMatchesCount = 3,
            SecondaryMatchesCount = 2,
            Sequence = false,
            Uniform = false,
            SequenceMinRank = null
        };

        FourOfAKind = new HandRanking {
            Name = "Four of a Kind",
            Value = 8,
            PrimaryMatchesCount = 4,
            SecondaryMatchesCount = 0,
            Sequence = false,
            Uniform = false,
            SequenceMinRank = null
        };

        StraightFlush = new HandRanking {
            Name = "Straight Flush",
            Value = 9,
            PrimaryMatchesCount = 0,
            SecondaryMatchesCount = 0,
            Sequence = true,
            Uniform = true,
            SequenceMinRank = ranks.Two
        };

        RoyalFlush = new HandRanking {
            Name = "Royal Flush",
            Value = 10,
            PrimaryMatchesCount = 0,
            SecondaryMatchesCount = 0,
            Sequence = true,
            Uniform = true,
            SequenceMinRank = ranks.Ten
        };

        FiveOfAKind = new HandRanking {
            Name = "Five of a Kind",
            Value = 11,
            PrimaryMatchesCount = 5,
            SecondaryMatchesCount = 0,
            Sequence = false,
            Uniform = false,
            SequenceMinRank = null
        };

        HandRankingsList = new(){
            HighCard,
            Pair,
            TwoPair,
            ThreeOfAKind,
            Straight,
            Flush,
            FullHouse,
            FourOfAKind,
            StraightFlush,
            RoyalFlush,
            FiveOfAKind
        };
    }
}
