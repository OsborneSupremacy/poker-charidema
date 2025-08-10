namespace Poker.Domain.Messaging;

public class GameResponse
{
    public required CompletedGame CompletedGame { get; init; }

    public required IReadOnlyList<Participant> Participants { get; init; }
}

public static class GameResponses
{
    public static GameResponse Empty { get; } = new()
    {
        CompletedGame = CompletedGames.Empty,
        Participants = []
    };
}
