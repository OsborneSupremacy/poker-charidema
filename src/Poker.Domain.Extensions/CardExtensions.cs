using Poker.Domain.Classic;

namespace Poker.Domain.Extensions;

public static class CardExtensions
{
    public static string ToStandardNotation(this Card input) =>
        $"{input.GetRankId()}{input.GetSymbol()}";

    public static string GetRankId(this Card input) =>
        input.CardType switch
        {
            CardTypes.Joker => "*",
            CardTypes.Ace => input.Rank!.Name[..1],
            CardTypes.Face => input.Rank!.Name[..1],
            CardTypes.Spot => input.Rank!.Value.ToString(),
           _ => throw new NotSupportedException(),
        };

    public static string GetSymbol(this Card input) =>
        input.Suit?.Name[..1].ToString().ToLowerInvariant() ?? string.Empty;

    public static bool MatchesRank(this Card input, Rank rank) =>
        input.Rank.Value == rank.Value;

    public static bool SatisfiesRank(this Card input, Rank minRank) =>
        input.Rank.Value >= minRank.Value;

    public static bool MatchesRankOrIsWild(this Card input, Rank rank) =>
        input.MatchesRank(rank)
        || input.IsWild;

    public static bool SatisfiesRankOrIsWild(this Card input, Rank minRank) =>
        input.SatisfiesRank(minRank)
        || input.IsWild;

    public static bool MatchesSuit(this Card input, Suit suit) =>
        input.Suit.Priority == suit.Priority;

    public static bool MatchesSuitOrIsWild(this Card input, Suit suit) =>
        input.MatchesSuit(suit)
        || input.IsWild;

    public static bool HasCountOfMatchingRank(this List<Card> input, Rank rank, uint count) =>
        input.Count(x => x.MatchesRank(rank)) >= count;

    public static bool HasCountOfMatchingRankOrWild(this List<Card> input, Rank rank, uint count) =>
        input.Count(x => x.MatchesRankOrIsWild(rank)) >= count;

    public static Rank GetBestMatchingRank(this List<Card> cards, uint count)
    {
        foreach(var rank in Ranks.All.OrderByDescending(r => r.Value))
            if (cards.HasCountOfMatchingRankOrWild(rank, count))
                return rank;
        return Ranks.Empty;
    }

    public static List<Card> GetMatchingRank(this List<Card> input, Rank rank) =>
        input.Where(x => x.MatchesRank(rank)).ToList();

    public static List<Card> GetMatchingRankOrWild(this List<Card> input, Rank rank) =>
        input.Where(x => x.MatchesRankOrIsWild(rank)).ToList();

    public static List<Card> GetMatchingRankHand(
        this List<Card> input,
        Rank rank,
        int count
        ) => input
            .Where(c => c.MatchesRankOrIsWild(rank))
            .OrderBy(c => c.IsWild)
            .ThenByDescending(c => c.Suit.Priority)
            .Take(count)
            .ToList();

    public static List<Card> GetKickers(
        this List<Card> input,
        List<Card> handCards) =>
            input
                .Except(handCards)
                .OrderByDescending(c => c.IsWild)
                .ThenByDescending(c => c.Rank.Value)
                .ThenByDescending(c => c.Suit.Priority)
                .Take(GlobalConstants.HandSize - handCards.Count)
                .ToList();

    public static List<Card> GetDeadCards(
        this List<Card> input,
        List<Card> handCards,
        List<Card> kickers
        ) =>
        input
            .Except(handCards)
            .Except(kickers)
            .ToList();

    public static QualifiedHand ToQualifiedHand(
        this List<Card> cards,
        Hand hand,
        List<Card> handCards)
    {
        var kickers = cards.GetKickers(handCards);

        return new QualifiedHand
        {
            Hand = hand,
            HandCards = handCards,
            Kickers = kickers,
            DeadCards = cards.GetDeadCards(handCards, kickers),
            HandQualification = HandQualifications.Qualifies
        };
    }

    public static QualifiedHand ToUnqualifiedHand(
        this List<Card> cards,
        Hand hand,
        bool possible
        ) =>
            new()
            {
                Hand = hand,
                HandCards = new(),
                DeadCards = cards,
                Kickers = new(),
                HandQualification =
                    possible
                    ? HandQualifications.Possible
                    : HandQualifications.Eliminated
            };
}
