namespace Poker.Library;

public record Rank
{
    public string Name { get; init; }

    public uint Value { get; init; }

    public Rank(string name, uint value)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Value = value;
    }
}
