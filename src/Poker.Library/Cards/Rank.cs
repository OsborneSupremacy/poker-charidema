using System.Diagnostics.CodeAnalysis;

namespace Poker.Library.Cards;

public record Rank
{
    public required string Name { get; init; }

    public required uint Value { get; init; }

    [SetsRequiredMembers]
    public Rank(string name, uint value)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Value = value;
    }
}
