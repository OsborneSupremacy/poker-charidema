namespace Poker.Library.Hands;

public class RoyalFlush : StraightFlush, IHandRanking
{
    public override string Name => "Royal Flush";

    public override uint Value => 90;

    public override IHandRankingResult Qualify(IHandRankingArgs args)
    {
        var deck = args.Deck;
        var playerCards = args.PlayerCards;

        var straightFlush = base.Qualify(args);
        if (!straightFlush.Qualifies)
            return new NoHand().Qualify(args);

        var maxRank = deck.CardRankValues.Max();

        return
            straightFlush.HandCards.All
            (
                x => x.IsWild
                || x is IStandardCard s && s.Rank.Value >= (maxRank - 4)
            )

            ? straightFlush
            : new NoHand().Qualify(args);
    }
}
