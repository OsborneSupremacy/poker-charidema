using System.Diagnostics.CodeAnalysis;

namespace Poker.Library;

public record Suit
{
    public required string Name { get; init; }

    public required uint Priority { get; init; }

    [SetsRequiredMembers]
    public Suit(string name, uint priority)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Priority = priority;
    }
}
