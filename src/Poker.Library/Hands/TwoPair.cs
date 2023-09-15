namespace Poker.Library.Hands;

public class TwoPair : IHandRanking, IPossibleHandRanking
{
    public string Name => "Two Pair";

    public uint Value => 30;

    public int RequiredMatches => 2;

    public IPossibleHandRankingResult QualifyPossible(IHandRankingArgs args)
    {
        var (qualifies, firstPair, secondPair) = GetQualifyingRank(args);

        if (!qualifies)
            return new PossibleRankHandingResult
            {
                Qualifies = false,
                HandCards = new(),
                NonHandCards = new()
            };

        var handCards = firstPair.Union(secondPair).ToList();

        return new PossibleRankHandingResult
        {
            Qualifies = true,
            HandCards = firstPair.Union(secondPair).ToList(),
            NonHandCards = args.PlayerCards.Except(handCards).ToList()
        };
    }

    public IHandRankingResult Qualify(IHandRankingArgs args)
    {
        var playerCards = args.PlayerCards;

        var (qualifies, firstPair, secondPair) = GetQualifyingRank(args);

        if (!qualifies)
            return new HandRankingResult
            {
                Qualifies = false,
                HandCards = new(),
                Kickers = new(),
                DeadCards = new()
            };

        var handCards = firstPair
            .Union(secondPair)
            .ToList();

        var kickers = playerCards.GetKickers(handCards, 5);

        return new HandRankingResult
        {
            Qualifies = true,
            HandCards = handCards,
            Kickers = kickers,
            DeadCards = playerCards.GetDeadCards(handCards, kickers)
        };
    }

    private (bool qualifies, List<ICard> firstPair, List<ICard> secondPair) GetQualifyingRank(IHandRankingArgs args)
    {
        var firstPairResult = new Pair().QualifyPossible(args);

        if (!firstPairResult.Qualifies)
            return (false, new(), new());

        var remainingCards = firstPairResult.NonHandCards;
        var secondPairResult = new Pair().QualifyPossible(
            new HandRankingArgs { Deck = args.Deck, PlayerCards = remainingCards }
        );

        if (!secondPairResult.Qualifies)
            return (false, new(), new());

        return (true, firstPairResult.HandCards, secondPairResult.HandCards);
    }
}
