namespace Poker.Domain.Messaging;

public record CoordinateGameResponse
{
    public required GameResponse GameResponse { get; init; }
}

public static class CoordinateGameResponses
{
    public static CoordinateGameResponse Empty { get; } = new()
    {
        GameResponse = GameResponses.Empty
    };
}
