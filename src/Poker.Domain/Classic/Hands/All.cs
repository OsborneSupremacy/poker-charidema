﻿
namespace Poker.Domain.Classic.Hands;

public static class AllHands
{
    public static List<Hand> All { get; } =
    [
        NoHands.NoHand,
        HighCards.Two,
        Pairs.Twos,
        ThreeOfAKind.Twos,
        FourOfAKind.Twos,
        FiveOfAKind.Twos,
        HighCards.Three,
        Pairs.Threes,
        ThreeOfAKind.Threes,
        FourOfAKind.Threes,
        FiveOfAKind.Threes,
        HighCards.Four,
        Pairs.Fours,
        ThreeOfAKind.Fours,
        FourOfAKind.Fours,
        FiveOfAKind.Fours,
        HighCards.Five,
        Pairs.Fives,
        ThreeOfAKind.Fives,
        FourOfAKind.Fives,
        FiveOfAKind.Fives,
        HighCards.Six,
        Pairs.Sixes,
        ThreeOfAKind.Sixes,
        FourOfAKind.Sixes,
        FiveOfAKind.Sixes,
        Straights.SixHigh,
        HighCards.Seven,
        Pairs.Sevens,
        ThreeOfAKind.Sevens,
        FourOfAKind.Sevens,
        FiveOfAKind.Sevens,
        Straights.SevenHigh,
        HighCards.Eight,
        Pairs.Eights,
        ThreeOfAKind.Eights,
        FourOfAKind.Eights,
        FiveOfAKind.Eights,
        Straights.EightHigh,
        HighCards.Nine,
        Pairs.Nines,
        ThreeOfAKind.Nines,
        FourOfAKind.Nines,
        FiveOfAKind.Nines,
        Straights.NineHigh,
        HighCards.Ten,
        Pairs.Tens,
        ThreeOfAKind.Tens,
        FourOfAKind.Tens,
        FiveOfAKind.Tens,
        Straights.TenHigh,
        HighCards.Jack,
        Pairs.Jacks,
        ThreeOfAKind.Jacks,
        FourOfAKind.Jacks,
        FiveOfAKind.Jacks,
        Straights.JackHigh,
        HighCards.Queen,
        Pairs.Queens,
        ThreeOfAKind.Queens,
        FourOfAKind.Queens,
        FiveOfAKind.Queens,
        Straights.QueenHigh,
        HighCards.King,
        Pairs.Kings,
        ThreeOfAKind.Kings,
        FourOfAKind.Kings,
        FiveOfAKind.Kings,
        Straights.KingHigh,
        HighCards.Ace,
        Pairs.Aces,
        ThreeOfAKind.Aces,
        FourOfAKind.Aces,
        FiveOfAKind.Aces,
        Straights.AceHigh,
        FullHouses.TwosOverThrees,
        FullHouses.TwosOverFours,
        FullHouses.TwosOverFives,
        FullHouses.TwosOverSixes,
        FullHouses.TwosOverSevens,
        FullHouses.TwosOverEights,
        FullHouses.TwosOverNines,
        FullHouses.TwosOverTens,
        FullHouses.TwosOverJacks,
        FullHouses.TwosOverQueens,
        FullHouses.TwosOverKings,
        FullHouses.TwosOverAces,
        TwoPair.ThreesOverTwos,
        FullHouses.ThreesOverTwos,
        FullHouses.ThreesOverFours,
        FullHouses.ThreesOverFives,
        FullHouses.ThreesOverSixes,
        FullHouses.ThreesOverSevens,
        FullHouses.ThreesOverEights,
        FullHouses.ThreesOverNines,
        FullHouses.ThreesOverTens,
        FullHouses.ThreesOverJacks,
        FullHouses.ThreesOverQueens,
        FullHouses.ThreesOverKings,
        FullHouses.ThreesOverAces,
        TwoPair.FoursOverTwos,
        FullHouses.FoursOverTwos,
        TwoPair.FoursOverThrees,
        FullHouses.FoursOverThrees,
        FullHouses.FoursOverFives,
        FullHouses.FoursOverSixes,
        FullHouses.FoursOverSevens,
        FullHouses.FoursOverEights,
        FullHouses.FoursOverNines,
        FullHouses.FoursOverTens,
        FullHouses.FoursOverJacks,
        FullHouses.FoursOverQueens,
        FullHouses.FoursOverKings,
        FullHouses.FoursOverAces,
        TwoPair.FivesOverTwos,
        FullHouses.FivesOverTwos,
        TwoPair.FivesOverThrees,
        FullHouses.FivesOverThrees,
        TwoPair.FivesOverFours,
        FullHouses.FivesOverFours,
        FullHouses.FivesOverSixes,
        FullHouses.FivesOverSevens,
        FullHouses.FivesOverEights,
        FullHouses.FivesOverNines,
        FullHouses.FivesOverTens,
        FullHouses.FivesOverJacks,
        FullHouses.FivesOverQueens,
        FullHouses.FivesOverKings,
        FullHouses.FivesOverAces,
        TwoPair.SixesOverTwos,
        FullHouses.SixesOverTwos,
        TwoPair.SixesOverThrees,
        FullHouses.SixesOverThrees,
        TwoPair.SixesOverFours,
        FullHouses.SixesOverFours,
        TwoPair.SixesOverFives,
        FullHouses.SixesOverFives,
        FullHouses.SixesOverSevens,
        FullHouses.SixesOverEights,
        FullHouses.SixesOverNines,
        FullHouses.SixesOverTens,
        FullHouses.SixesOverJacks,
        FullHouses.SixesOverQueens,
        FullHouses.SixesOverKings,
        FullHouses.SixesOverAces,
        TwoPair.SevensOverTwos,
        FullHouses.SevensOverTwos,
        TwoPair.SevensOverThrees,
        FullHouses.SevensOverThrees,
        TwoPair.SevensOverFours,
        FullHouses.SevensOverFours,
        TwoPair.SevensOverFives,
        FullHouses.SevensOverFives,
        TwoPair.SevensOverSixes,
        FullHouses.SevensOverSixes,
        FullHouses.SevensOverEights,
        FullHouses.SevensOverNines,
        FullHouses.SevensOverTens,
        FullHouses.SevensOverJacks,
        FullHouses.SevensOverQueens,
        FullHouses.SevensOverKings,
        FullHouses.SevensOverAces,
        TwoPair.EightsOverTwos,
        FullHouses.EightsOverTwos,
        TwoPair.EightsOverThrees,
        FullHouses.EightsOverThrees,
        TwoPair.EightsOverFours,
        FullHouses.EightsOverFours,
        TwoPair.EightsOverFives,
        FullHouses.EightsOverFives,
        TwoPair.EightsOverSixes,
        FullHouses.EightsOverSixes,
        TwoPair.EightsOverSevens,
        FullHouses.EightsOverSevens,
        FullHouses.EightsOverNines,
        FullHouses.EightsOverTens,
        FullHouses.EightsOverJacks,
        FullHouses.EightsOverQueens,
        FullHouses.EightsOverKings,
        FullHouses.EightsOverAces,
        TwoPair.NinesOverTwos,
        FullHouses.NinesOverTwos,
        TwoPair.NinesOverThrees,
        FullHouses.NinesOverThrees,
        TwoPair.NinesOverFours,
        FullHouses.NinesOverFours,
        TwoPair.NinesOverFives,
        FullHouses.NinesOverFives,
        TwoPair.NinesOverSixes,
        FullHouses.NinesOverSixes,
        TwoPair.NinesOverSevens,
        FullHouses.NinesOverSevens,
        TwoPair.NinesOverEights,
        FullHouses.NinesOverEights,
        FullHouses.NinesOverTens,
        FullHouses.NinesOverJacks,
        FullHouses.NinesOverQueens,
        FullHouses.NinesOverKings,
        FullHouses.NinesOverAces,
        TwoPair.TensOverTwos,
        FullHouses.TensOverTwos,
        TwoPair.TensOverThrees,
        FullHouses.TensOverThrees,
        TwoPair.TensOverFours,
        FullHouses.TensOverFours,
        TwoPair.TensOverFives,
        FullHouses.TensOverFives,
        TwoPair.TensOverSixes,
        FullHouses.TensOverSixes,
        TwoPair.TensOverSevens,
        FullHouses.TensOverSevens,
        TwoPair.TensOverEights,
        FullHouses.TensOverEights,
        TwoPair.TensOverNines,
        FullHouses.TensOverNines,
        FullHouses.TensOverJacks,
        FullHouses.TensOverQueens,
        FullHouses.TensOverKings,
        FullHouses.TensOverAces,
        TwoPair.JacksOverTwos,
        FullHouses.JacksOverTwos,
        TwoPair.JacksOverThrees,
        FullHouses.JacksOverThrees,
        TwoPair.JacksOverFours,
        FullHouses.JacksOverFours,
        TwoPair.JacksOverFives,
        FullHouses.JacksOverFives,
        TwoPair.JacksOverSixes,
        FullHouses.JacksOverSixes,
        TwoPair.JacksOverSevens,
        FullHouses.JacksOverSevens,
        TwoPair.JacksOverEights,
        FullHouses.JacksOverEights,
        TwoPair.JacksOverNines,
        FullHouses.JacksOverNines,
        TwoPair.JacksOverTens,
        FullHouses.JacksOverTens,
        FullHouses.JacksOverQueens,
        FullHouses.JacksOverKings,
        FullHouses.JacksOverAces,
        TwoPair.QueensOverTwos,
        FullHouses.QueensOverTwos,
        TwoPair.QueensOverThrees,
        FullHouses.QueensOverThrees,
        TwoPair.QueensOverFours,
        FullHouses.QueensOverFours,
        TwoPair.QueensOverFives,
        FullHouses.QueensOverFives,
        TwoPair.QueensOverSixes,
        FullHouses.QueensOverSixes,
        TwoPair.QueensOverSevens,
        FullHouses.QueensOverSevens,
        TwoPair.QueensOverEights,
        FullHouses.QueensOverEights,
        TwoPair.QueensOverNines,
        FullHouses.QueensOverNines,
        TwoPair.QueensOverTens,
        FullHouses.QueensOverTens,
        TwoPair.QueensOverJacks,
        FullHouses.QueensOverJacks,
        FullHouses.QueensOverKings,
        FullHouses.QueensOverAces,
        TwoPair.KingsOverTwos,
        FullHouses.KingsOverTwos,
        TwoPair.KingsOverThrees,
        FullHouses.KingsOverThrees,
        TwoPair.KingsOverFours,
        FullHouses.KingsOverFours,
        TwoPair.KingsOverFives,
        FullHouses.KingsOverFives,
        TwoPair.KingsOverSixes,
        FullHouses.KingsOverSixes,
        TwoPair.KingsOverSevens,
        FullHouses.KingsOverSevens,
        TwoPair.KingsOverEights,
        FullHouses.KingsOverEights,
        TwoPair.KingsOverNines,
        FullHouses.KingsOverNines,
        TwoPair.KingsOverTens,
        FullHouses.KingsOverTens,
        TwoPair.KingsOverJacks,
        FullHouses.KingsOverJacks,
        TwoPair.KingsOverQueens,
        FullHouses.KingsOverQueens,
        FullHouses.KingsOverAces,
        TwoPair.AcesOverTwos,
        FullHouses.AcesOverTwos,
        TwoPair.AcesOverThrees,
        FullHouses.AcesOverThrees,
        TwoPair.AcesOverFours,
        FullHouses.AcesOverFours,
        TwoPair.AcesOverFives,
        FullHouses.AcesOverFives,
        TwoPair.AcesOverSixes,
        FullHouses.AcesOverSixes,
        TwoPair.AcesOverSevens,
        FullHouses.AcesOverSevens,
        TwoPair.AcesOverEights,
        FullHouses.AcesOverEights,
        TwoPair.AcesOverNines,
        FullHouses.AcesOverNines,
        TwoPair.AcesOverTens,
        FullHouses.AcesOverTens,
        TwoPair.AcesOverJacks,
        FullHouses.AcesOverJacks,
        TwoPair.AcesOverQueens,
        FullHouses.AcesOverQueens,
        TwoPair.AcesOverKings,
        FullHouses.AcesOverKings,
        Flushes.Spades,
        RoyalFlushes.Spades,
        Flushes.Hearts,
        RoyalFlushes.Hearts,
        Flushes.Clubs,
        RoyalFlushes.Clubs,
        Flushes.Diamonds,
        RoyalFlushes.Diamonds,
        StraightFlushes.SixHighSpades,
        StraightFlushes.SevenHighSpades,
        StraightFlushes.EightHighSpades,
        StraightFlushes.NineHighSpades,
        StraightFlushes.TenHighSpades,
        StraightFlushes.JackHighSpades,
        StraightFlushes.QueenHighSpades,
        StraightFlushes.KingHighSpades,
        StraightFlushes.SixHighHearts,
        StraightFlushes.SevenHighHearts,
        StraightFlushes.EightHighHearts,
        StraightFlushes.NineHighHearts,
        StraightFlushes.TenHighHearts,
        StraightFlushes.JackHighHearts,
        StraightFlushes.QueenHighHearts,
        StraightFlushes.KingHighHearts,
        StraightFlushes.SixHighClubs,
        StraightFlushes.SevenHighClubs,
        StraightFlushes.EightHighClubs,
        StraightFlushes.NineHighClubs,
        StraightFlushes.TenHighClubs,
        StraightFlushes.JackHighClubs,
        StraightFlushes.QueenHighClubs,
        StraightFlushes.KingHighClubs,
        StraightFlushes.SixHighDiamonds,
        StraightFlushes.SevenHighDiamonds,
        StraightFlushes.EightHighDiamonds,
        StraightFlushes.NineHighDiamonds,
        StraightFlushes.TenHighDiamonds,
        StraightFlushes.JackHighDiamonds,
        StraightFlushes.QueenHighDiamonds,
        StraightFlushes.KingHighDiamonds
    ];
}
