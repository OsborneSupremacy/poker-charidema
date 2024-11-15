﻿namespace Poker.Service.Abstractions;

/// <summary>
/// Evaluates the current lead player. Uses face up cards only.
/// </summary>
public interface ILeadPlayerService
{
    Task<EvaluateLeaderPlayerResponse> ExecuteAsync(EvaluateLeadPlayerRequest request);
}
