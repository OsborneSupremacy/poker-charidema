﻿namespace Poker.Service.Interface;

public interface IRandomFactory
{
    Random Create();

    int GetSeed();
}
