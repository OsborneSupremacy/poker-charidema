namespace Poker.Domain.Functions;

public static class SuitFunctions
{
    public static List<Suit> GetOrderedSuits() =>
        Suits.All.OrderByDescending(x => x.Priority).ToList();
}
