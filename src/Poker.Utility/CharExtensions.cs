namespace Poker.Utility;

public static class CharExtensions
{
    public static string Repeat(this char input, int count) =>
        new(input, 50);
}
