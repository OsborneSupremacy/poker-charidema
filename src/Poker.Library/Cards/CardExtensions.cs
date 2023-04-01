namespace Poker.Library.Cards;

public static class CardExtensions
{
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
}