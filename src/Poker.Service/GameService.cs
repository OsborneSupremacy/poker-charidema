using System.Text;
using Poker.Library.RoundActions;

namespace Poker.Service;

public class GameService : IGameService
{
    private readonly IDealerService _dealerService;

    private readonly IRoundActionService _roundActionService;

    public GameService(
        IDealerService dealerService,
        IRoundActionService roundActionService
        )
    {
        _dealerService = dealerService ?? throw new ArgumentNullException(nameof(dealerService));
        _roundActionService = roundActionService ?? throw new ArgumentNullException(nameof(roundActionService));
    }

    protected Task WriteGameInfoAsync(Game game)
    {
        StringBuilder s = new();
        s.AppendLine("New game starting!");
        s.AppendLine();
        s.AppendLine($"The game type is ");


        return Task.CompletedTask;
    }

    public async Task<Game> PlayAsync(GameArgs args)
    {
        Game game = new()
        {
            Variant = args.Variant,
            Players = args.Players,
            Deck = args.Deck,
            CommunityCards = new(),
            Discards = new(),
            Rounds = null
        };

        var deck = await _dealerService.ShuffleAsync(args.Deck);

        foreach (var action in args.Variant.RoundActions)
        {
            var result = await _roundActionService
                .ExecuteAsync(new RoundActionArgs()
                {
                    RoundAction = action,
                    Deck = deck,
                    Players = args.Players
                });
            if (result.GameOver)
                return game;
        }

        return game;
    }
}
