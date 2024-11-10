using System.Globalization;

namespace Poker.Utility;

public static class StringExtensions
{
    public static bool IsNullOrWhiteSpace(this string? input) =>
        string.IsNullOrWhiteSpace(input);

    public static string ToTitleCase(this string? input) =>
        input.IsNullOrWhiteSpace() ? string.Empty : CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input!);
}
