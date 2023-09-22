public static class UintExtensions
{
    public static int ToInt(this uint value) =>
        (int)value;

    public static uint ValueOrZero(this uint? input) =>
        input ?? 0;

    public static uint ValueOrMax(this uint? input) =>
        input ?? uint.MaxValue;
}
