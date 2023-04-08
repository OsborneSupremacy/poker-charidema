namespace Poker.Library;

public record InGamePlayer : IInGamePlayer
{
    public required IPlayer Player { get; init; }

    public required double Stack { get; init; }

    public required bool Folded { get; init; }
}
