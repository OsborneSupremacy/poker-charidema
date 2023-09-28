using System.Drawing;

namespace Poker.Domain;

public record Suit
{
    public required string Name { get; init; }

    public required Color Color { get; init; }

    public required char Symbol { get; init; }

    /// <summary>
    /// Even though suits are all equally valuable, we want to be able to
    /// this gives us a way of consistently sorting and selecting cards.
    /// </summary>
    public required uint Priority { get; init; }
}
