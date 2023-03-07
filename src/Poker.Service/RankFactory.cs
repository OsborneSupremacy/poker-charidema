namespace Poker.Service;

public class RankFactory
{
    public List<Rank> CreateStandard() =>
        new()
        {
            new("Two", 2),
            new("Three", 3),
            new("Four", 4),
            new("Five", 5),
            new("Six", 6),
            new("Seven", 7),
            new("Eight", 8),
            new("Nine", 9),
            new("Ten", 10),
            new("Jack", 11),
            new("Queen", 12),
            new("King", 13),
            new("Ace", 14)
        };
}
