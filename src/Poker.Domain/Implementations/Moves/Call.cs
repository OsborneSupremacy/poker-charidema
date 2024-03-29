﻿namespace Poker.Domain.Implementations.Moves;

public record Call : IWageringMove
{
    public string ImperativeName => "Call";

    public string DescriptiveName => "calls";
}
