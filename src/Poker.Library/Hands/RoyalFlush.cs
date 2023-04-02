namespace Poker.Library.Hands;

public class RoyalFlush : StraightFlush
{
    public override string Name => "Royal Flush";

    public override uint Value => 90;

    public override IHandRankingResult Qualify(IDeck deck, List<ICard> playerCards)
    {
        var straightFlush = base.Qualify(deck, playerCards);
        if (!straightFlush.Qualifies) return NoHand;

        var maxRank = deck.CardRankValues.Max();

        return
            straightFlush.HandCards.All
            (
                x => x.IsWild
                || x is IStandardCard s && s.Rank.Value >= (maxRank - 4)
            )

            ? straightFlush
            : NoHand;
    }

    private static HandRankingResult NoHand => new HandRankingResult
    {
        Qualifies = false,
        HandCards = new(),
        Kickers = new(),
        DeadCards = new()
    };
}
