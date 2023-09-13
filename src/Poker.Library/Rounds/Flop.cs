using System.Diagnostics.CodeAnalysis;

namespace Poker.Library.Rounds;

public record Flop : DealCards, IBoardAction
{
    [SetsRequiredMembers]
    public Flop()
    {
        Count = 3;
        Name = "The Flop";
        CardOrientation = CardOrientations.Faceup;
        CardDestination = CardLocations.Community;
    }
}
