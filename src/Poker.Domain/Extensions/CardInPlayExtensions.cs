﻿namespace Poker.Domain.Extensions;

public static class CardInPlayExtensions
{
    public static List<Card> ToCards(this IEnumerable<CardInPlay> input) =>
        input
            .Select(x => x.Card)
            .ToList();
}