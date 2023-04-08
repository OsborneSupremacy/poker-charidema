using Poker.Library.RoundActions;

namespace Poker.Service;

public class RoundActionService : IRoundActionService
{
    private readonly IGamePreferencesService _gamePreferencesService;

    public RoundActionService(IGamePreferencesService gamePreferencesService)
    {
        _gamePreferencesService = gamePreferencesService ?? throw new ArgumentNullException(nameof(gamePreferencesService));
    }

    protected Task WriteStartInfoAsync(RoundActionArgs args)
    {
        _gamePreferencesService.WriteLines(
            $"Round {args.RoundNumber} - {args.RoundAction.Name}"
        );

        return Task.CompletedTask;
    }

    public async Task<RoundActionResult> ExecuteAsync(RoundActionArgs args)
    {
        await WriteStartInfoAsync(args);

        var playersIn = args.Players;
        var playersOut = new List<Player>();

        var currentPlayer = args.StartingPlayer;
        
        // TODO: if this is a betting round, start with player showing
        // best hand

        for(var p = 0; p < args.Players.Count; p++)
        {
            _gamePreferencesService.WriteLines($"{playersIn[p].Player.Name}'s turn.");
            

            currentPlayer = args.Players.NextPlayer(currentPlayer);
        }

        var result = new RoundActionResult
        {
            GameOver = false,
            Players = playersOut
        };

        return result;
    }
}
