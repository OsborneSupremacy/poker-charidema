﻿namespace Poker.Domain;

public record Match
{
    public required uint FixedNumberOfGames { get; init; }

    public required Variant FixedVariant { get; init; }

    public Deck? FixedDeck {  get; init; }

    public required List<Participant> Players { get; init; }

    public required List<GameResponse> Games { get; init; }

    public required AntePreferences AntePreferences { get; init; }

    public required uint StartingStack { get; init; }
}

public record AntePreferences
{
    public required uint Min { get; init; }

    public required uint Max { get; init; }

    public required uint Fixed { get; init; }

    public required AnteTypes AnteType { get; init; }
}

public enum AnteTypes
{
    Fixed,
    DealersChoice
}