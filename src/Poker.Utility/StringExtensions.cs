using System.Globalization;

namespace Poker.Utility;

public static class StringExtensions
{
    public static bool IsNullOrWhiteSpace(this string? input) =>
        string.IsNullOrWhiteSpace(input);

    public static string ToTitleCase(this string? input) =>
        input.IsNullOrWhiteSpace() ? string.Empty : CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input!);

    /// <summary>
    /// Prefixes the input with "a" or "an" (e.g. "a King", "an Ace"). Decided by the
    /// first letter only, which is right for card ranks but not for every word
    /// (e.g. "an hour", "a unicorn").
    /// </summary>
    public static string WithIndefiniteArticle(this string input) =>
        "aeiouAEIOU".Contains(input.TrimStart().FirstOrDefault()) ? $"an {input}" : $"a {input}";
}
