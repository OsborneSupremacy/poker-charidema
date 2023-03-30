using System.Diagnostics.CodeAnalysis;
using System.Drawing;

namespace Poker.Library.Cards;

public record Suit : ISuit
{
    public required string Name { get; init; }

    public required Color Color { get; init; }

    public required uint Priority { get; init; }

    [SetsRequiredMembers]
    public Suit(string name, uint priority, Color color)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Priority = priority;
        Color = color;
    }
}
