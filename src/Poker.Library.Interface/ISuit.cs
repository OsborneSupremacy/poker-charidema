using System.Drawing;

namespace Poker.Library.Interface;

public interface ISuit
{
    string Name { get; init; }

    Color Color { get; init; }

    uint Priority { get; init; }

    char Symbol { get; init; }
}
