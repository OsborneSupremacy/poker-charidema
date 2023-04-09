using Poker.Library.Cards;

namespace Poker.Service;

public class SuitFactory
{
    public List<Suit> CreateClassic() =>
        new() {
            new("Spades", 1, System.Drawing.Color.Black),
            new("Hearts", 2, System.Drawing.Color.Red),
            new("Diamonds", 3, System.Drawing.Color.Red),
            new("Clubs", 4, System.Drawing.Color.Black)
        };
}
