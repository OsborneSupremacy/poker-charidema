﻿namespace Poker.Service.Interface;

public interface IPhaseService
{
    public Task<PhaseResult> ExecuteAsync(PhaseArgs args);
}
