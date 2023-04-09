﻿namespace Poker.Library.Interface;

public interface IInGamePlayer
{
    IPlayer Player { get; init; }

    List<ICard> Cards { get; init; }

    double Stack { get; init; }

    bool Folded { get; init; }
}