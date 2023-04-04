namespace Poker.Library;

public record Player
{
    public required Guid Id { get; init; }

    public required string Name { get; init; }

    public required double BeginningStack { get; init; }

    public required double Stack { get; init; }
}
