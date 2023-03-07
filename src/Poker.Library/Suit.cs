namespace Poker.Library;

public record Suit
{
    public string Name { get; init; }

    public uint Priority { get; init; }

    public Suit(string name, uint priority)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Priority = priority;
    }
}
