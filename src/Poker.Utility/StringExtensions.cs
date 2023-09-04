namespace Poker.Utility;

public static class StringExtensions
{
    public static bool IsNullOrWhiteSpace(this string? input) =>
        string.IsNullOrWhiteSpace(input);

    public static void DoIfNotNullOrWhiteSpace(this string? input, Action action)
    {
        if (!input.IsNullOrWhiteSpace())
            action();
    }
}
