﻿namespace Poker.Library.Interface;

public interface IHandRankingResult
{
    bool Qualifies { get; }

    List<ICard> HandCards { get; }

    List<ICard> Kickers { get; }

    List<ICard> DeadCards { get; }
}
