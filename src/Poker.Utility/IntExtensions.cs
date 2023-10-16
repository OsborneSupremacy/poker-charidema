namespace Poker.Utility;

public static class IntExtensions
{
    public static int ValueOrZero(this int? input) =>
        input ?? 0;

    public static int ValueOrMax(this int? input) =>
        input ?? int.MaxValue;

    /// <summary>
    /// Whether <paramref name="input"/> has a non-zero value.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool HasValue(this int input) =>
        input != 0;
}
