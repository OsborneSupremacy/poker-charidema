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
    public required string Name { get; init; }

    public required PhaseType PhaseType { get; init; }

    public required bool GameCanEndAfter { get; init; }

    public required uint CardsToDealCount { get; init; }

    public required CardLocations CardDestination { get; init; }

    public required CardOrientations CardOrientation { get; init; }

    public required uint CardsToDrawMaximum { get; init; }

    public required List<DrawCardsMaximums> CardsToDrawMaximumOverrides { get; init; }
}

public record DrawCardsMaximums
{
    public required Rank Rank { get; set; }

    public required uint Maximum { get; set; }
}

