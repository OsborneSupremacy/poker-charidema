namespace Poker.Domain;

public enum PhaseType
{
    Ante,
    Deal,
    Draw,
    BettingInterval,
    Evaluation
}

public record Phase
{
    public required int Number { get; init; }

    public required string Name { get; init; }

    public required PhaseType PhaseType { get; init; }

    public required bool GameCanEndAfter { get; init; }

    public required int CardsToDealCount { get; init; }

    public required CardLocations CardDestination { get; init; }

    public required CardOrientations CardOrientation { get; init; }

    public required int CardsToDrawMaximum { get; init; }

    public required List<DrawCardsMaximums> CardsToDrawMaximumOverrides { get; init; }
}

public record DrawCardsMaximums
{
    public required Rank Rank { get; set; }

    public required int Maximum { get; set; }
}

