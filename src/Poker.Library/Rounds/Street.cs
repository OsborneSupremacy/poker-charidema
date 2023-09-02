using System.Diagnostics.CodeAnalysis;

namespace Poker.Library.Rounds;

public record Street : DealCards
{
    [SetsRequiredMembers]
    public Street()
    {
        Count = 1;
        Name = "The Street";
        CardOrientation = CardOrientations.Faceup;
        CardDestination = CardLocations.Community;
    }
}
