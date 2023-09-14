namespace Poker.Library.Cards;

public static class CardExtensions
{
    public static string ToStandardNotation(this ICard input) =>
        $"{input.GetRankId()}{input.GetSymbol()}";

    public static string GetRankId(this ICard input) =>
        input switch
        {
            Joker => "*",
            Face => ((Face)input).Rank.Name[..1],
            IStandardCard => ((IStandardCard)input).Rank.Value.ToString(),
            _ => "?"
        };

    public static string GetSymbol(this ICard input)
    {
        if(input is not IStandardCard standardCard) return string.Empty;
        return standardCard.Suit.Name[..1].ToString().ToLowerInvariant();
    }

    public static ISuit? GetNonWildSuit(this ICard input)
    {
        if (input.IsWild())
            return null;
        return input is IStandardCard s ? s.Suit : null;
    }

    public static bool MatchesRank(this ICard input, uint rankValue) =>
        input is IStandardCard s
            && s.Rank.Value == rankValue;

    public static bool IsStandardWild(this ICard input) =>
        input is IStandardCard s
            && s.IsWild;

    public static bool IsWild(this ICard input) =>
        input.IsStandardWild()
        || input is Joker;

    public static bool MatchesRankOrIsWild(this ICard input, uint rankValue) =>
        input.MatchesRank(rankValue)
        || input.IsWild();

    public static bool MatchesSuit(this ICard input, uint suitPriority) =>
        input is IStandardCard s
            && s.Suit.Priority == suitPriority;

    public static bool MatchesSuitOrIsWild(this ICard input, uint suitPriority) =>
        input.MatchesSuit(suitPriority)
        || input.IsWild();

    public static bool HasCountOfMatchingRank(this IList<ICard> input, uint rankValue, int count) =>
        input.Count(x => x.MatchesRank(rankValue)) >= count;

    public static bool HasCountOfMatchingRankOrWild(this IList<ICard> input, uint rankValue, int count) =>
        input.Count(x => x.MatchesRankOrIsWild(rankValue)) >= count;

    public static List<ICard> GetMatchingRank(this IList<ICard> input, uint rankValue) =>
        input.Where(x => x.MatchesRank(rankValue)).ToList();

    public static List<ICard> GetMatchingRankOrWild(this IList<ICard> input, uint rankValue) =>
        input.Where(x => x.MatchesRankOrIsWild(rankValue)).ToList();

    public static List<ICard> GetKickers(this IList<ICard> input, List<ICard> handCards, int handLimit)
    {
        List<ICard> nonHandCards = input
            .Except(handCards).ToList();

        List<ICard> jokers = nonHandCards
            .Where(j => j is Joker).ToList();

        List<ICard> additionalCards = nonHandCards
            .Where(c => c is IStandardCard s)
            .OrderByDescending(c => (c as IStandardCard)!.Rank.Value)
            .ThenByDescending(c => (c as IStandardCard)!.Suit.Priority)
            .Take(handLimit - jokers.Count)
            .ToList();

        return jokers
            .Union(additionalCards)
            .ToList();
    }

    public static List<ICard> GetDeadCards(
        this IList<ICard> input,
        List<ICard> handCards,
        List<ICard> kickers
        ) =>
        input
            .Except(handCards)
            .Except(kickers)
            .ToList();
}
