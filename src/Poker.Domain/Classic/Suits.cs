namespace Poker.Domain.Classic;

public static class Suits
{
    public static Suit Empty { get; } = new()
    {
        Name = nameof(Empty),
        Priority = 0,
        Color = System.Drawing.Color.Empty,
        Symbol = char.MinValue
    };

    public static Suit Hearts { get; } = new()
    {
        Name = nameof(Hearts),
        Priority = 3,
        Color = System.Drawing.Color.Red,
        Symbol = '♥'
    };

    public static Suit Diamonds { get; } = new()
    {
        Name = nameof(Diamonds),
        Priority = 2,
        Color = System.Drawing.Color.Red,
        Symbol = '♦'
    };

    public static Suit Clubs { get; } = new()
    {
        Name = nameof(Clubs),
        Priority = 1,
        Color = System.Drawing.Color.Black,
        Symbol = '♣'
    };

    public static Suit Spades { get; } = new()
    {
        Name = nameof(Spades),
        Priority = 4,
        Color = System.Drawing.Color.Black,
        Symbol = '♠'
    };

    public static List<Suit> All { get; } =
    [
        Hearts,
        Diamonds,
        Clubs,
        Spades
    ];
}
