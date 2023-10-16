namespace Poker.Domain;

public record Rank
{
    public required string Name { get; init; }

    public required int Value { get; init; }

    [SetsRequiredMembers]
    public Rank(string name, int value)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Value = value;
    }
}
