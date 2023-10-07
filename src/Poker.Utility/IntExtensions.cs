namespace Poker.Utility;

public static class IntExtensions
{
    public static uint ToUint(this int input)
    {
        if (input < 0)
            throw new ArgumentOutOfRangeException(nameof(input), input, "Must be greater than or equal to zero.");
        return (uint)input;
    }
}
