namespace Poker.Service.Abstractions;

/// <summary>
/// An intermediary between the match and a particular game.
/// </summary>
public interface IGameCoordinator
{
    Task<CoordinateGameResponse> ExecuteAsync(CoordinateGameRequest request);
}
