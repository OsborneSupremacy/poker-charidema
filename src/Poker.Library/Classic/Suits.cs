using Poker.Library.Cards;

namespace Poker.Library.Classic;

public class Suits
{
    public Suit Hearts { get; }

    public Suit Diamonds { get; }

    public Suit Clubs { get; }

    public Suit Spades { get; }

    public Suits()
    {
        Clubs = new Suit(nameof(Clubs), 1, System.Drawing.Color.Black);
        Diamonds = new Suit(nameof(Diamonds), 2, System.Drawing.Color.Red);
        Hearts = new Suit(nameof(Hearts), 3, System.Drawing.Color.Red);
        Spades = new Suit(nameof(Spades), 4, System.Drawing.Color.Black);
    }
}
