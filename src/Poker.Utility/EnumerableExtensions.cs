namespace Poker.Utility;

public static class EnumerableExtensions
{
    public static Queue<T> ToQueue<T>(this IEnumerable<T> input)
    {
        Queue<T> queue = new();
        input
            .ToList()
            .ForEach(queue.Enqueue);
        return queue;
    }
}
