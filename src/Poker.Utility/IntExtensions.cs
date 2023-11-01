namespace Poker.Utility;

public static class IntExtensions
{
    /// <summary>
    /// Whether <paramref name="input"/> has a non-zero value.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool HasValue(this int input) =>
        input != 0;
}
