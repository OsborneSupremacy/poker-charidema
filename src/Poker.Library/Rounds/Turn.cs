using System.Diagnostics.CodeAnalysis;

namespace Poker.Library.Rounds;

public record Turn : DealCards
{
    [SetsRequiredMembers]
    public Turn()
    {
        Count = 1;
        Name = "The Turn";
        CardOrientation = CardOrientations.Faceup;
        CardDestination = CardLocations.Community;
    }
}
