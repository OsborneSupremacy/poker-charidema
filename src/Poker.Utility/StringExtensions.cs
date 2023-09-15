namespace Poker.Utility;

public static class StringExtensions
{
    public static bool IsNullOrWhiteSpace(this string? input) =>
        string.IsNullOrWhiteSpace(input);
}
