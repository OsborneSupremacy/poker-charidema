namespace Poker.Domain.Classic;

public class Suits
{
    public static Suit Empty { get; } = new Suit(nameof(Empty), 0, System.Drawing.Color.Empty, char.MinValue);

    public static Suit Hearts { get; } = new Suit(nameof(Hearts), 3, System.Drawing.Color.Red, '♥');

    public static Suit Diamonds { get; } = new Suit(nameof(Diamonds), 2, System.Drawing.Color.Red, '♦');

    public static Suit Clubs { get; } = new Suit(nameof(Clubs), 1, System.Drawing.Color.Black, '♣');

    public static Suit Spades { get; } = new Suit(nameof(Spades), 4, System.Drawing.Color.Black, '♠');

    public static List<Suit> AllSuits { get; } = new() { 
        Hearts,
        Diamonds,
        Clubs,
        Spades
    };
}
