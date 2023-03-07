namespace Poker.Service;

public class SuitFactory
{
    public List<Suit> CreateStandard() =>
        new() {
            new("Spades", 1),
            new("Hearts", 2),
            new("Diamonds", 3),
            new("Clubs", 4)
        };
}
