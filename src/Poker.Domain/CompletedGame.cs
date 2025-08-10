namespace Poker.Domain;

public record CompletedGame
{
    public required Guid Id { get; init; }

    public required int GameNumber { get; init; }

    public required Variant Variant { get; init; }

    public required IReadOnlyList<Participant> Participants { get; init; }

    public required IReadOnlyList<Participant> Winners { get; init; }

    public required Participant Button { get; init; }

    public required int PrizeAmount { get; init; }

    public required int PrizePerWinner { get; init; }
}

public static class CompletedGames
{
    public static CompletedGame Empty { get; } = new()
    {
        Id = Guid.Empty,
        GameNumber = 0,
        Participants = [],
        Winners = [],
        Button = Participants.Empty,
        Variant = EmptyVariant.GetVariant(),
        PrizeAmount = 0,
        PrizePerWinner = 0
    };
}
