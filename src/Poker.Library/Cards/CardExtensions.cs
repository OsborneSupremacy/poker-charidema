namespace Poker.Library.Cards;
public static class CardExtensions
{
    public static bool MatchesRank(this ICard input, uint rankValue) =>
        input is Standard s
            && s.Rank.Value == rankValue;

    public static bool IsStandardWild(this ICard input) =>
        input is Standard s
            && s.IsWild;

    public static bool IsWild(this ICard input) =>
        input.IsStandardWild()
        || input is Joker;

    public static bool MatchesRankOrIsWild(this ICard input, uint rankValue) =>
        input.MatchesRank(rankValue)
        || input.IsWild();
}