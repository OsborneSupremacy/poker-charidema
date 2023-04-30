using Poker.Library.Rounds;
using Poker.Presentation.Interface;

namespace Poker.Service;

public class RoundService : IRoundService
{
    private readonly IGamePreferencesService _gamePreferencesService;

    private readonly IUserInterfaceService _userInterfaceService;

    public RoundService(
        IGamePreferencesService gamePreferencesService,
        IUserInterfaceService userInterfaceService)
    {
        _gamePreferencesService = gamePreferencesService ?? throw new ArgumentNullException(nameof(gamePreferencesService));
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
    }

    protected Task WriteStartInfoAsync(RoundArgs args)
    {
        _userInterfaceService.WriteLines(
            $"Round {args.RoundNumber} - {args.Round.Name}"
        );

        return Task.CompletedTask;
    }

    public async Task<RoundResult> ExecuteAsync(RoundArgs args)
    {
        await WriteStartInfoAsync(args);

        var playersOut = new List<IInGamePlayer>();

        // I'd like to use Nondestructive mutation, but can't be used with interfaces
        var ccOut = args.CommunityCards.DeepClone();
        var deckOut = args.Deck.DeepClone();
        var potOut = args.Pot.DeepClone();

        // TODO: if this is a betting round, start with player showing
        // best hand
        for (var p = 0; p < args.Players.Count; p++)
        {
            var playerInTurn = args.Players[p];

            _userInterfaceService
                .WriteLines($"{playerInTurn.Player.Name}'s turn.");

            playersOut.Add(playerInTurn);
        }

        var result = new RoundResult
        {
            Deck = deckOut,
            CommunityCards = ccOut,
            Players = playersOut,
            GameOver = false,
            Pot = potOut
        };

        return result;
    }
}
