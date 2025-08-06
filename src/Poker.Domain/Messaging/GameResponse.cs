namespace Poker.Domain.Messaging;

public class GameResponse
{
    public required Game Game { get; init; }

    public required IReadOnlyList<Participant> Participants { get; init; }

    public required Variant Variant { get; init; }

    public required Participant Button { get; init; }
}

public static class GameResponses
{
    public static GameResponse Empty { get; } = new()
    {
        Game = Games.Empty,
        Participants = [],
        Variant = Implementations.Variants.EmptyVariant.GetVariant(),
        Button = Participants.Empty
    };
}
